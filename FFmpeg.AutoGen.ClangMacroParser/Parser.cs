using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using FFmpeg.AutoGen.ClangMacroParser.Expressions;
using FFmpeg.AutoGen.ClangMacroParser.Tokenization;

namespace FFmpeg.AutoGen.ClangMacroParser
{
    public static class Parser
    {
        public static IExpression Parse(string expression)
        {
            Token[] tokens = Tokenizer.Tokenize(expression).ToArray();

            var i = 0;
            bool CanRead() => i < tokens.Length;
            Token Read() => tokens[i++];
            Token Current() => tokens[i];

            bool IsSequenceOf(params Func<Token, bool>[] tests) =>
                i + tests.Length < tokens.Length
                && tests.Select((test, index) => new { test, token = tokens[i + index] }).All(x => x.test(x.token));

            IExpression Constant()
            {
                var t = Read();
                var value = t.Value;

                switch (t.TokenType)
                {
                    case TokenType.Number:
                        return new ConstantExpression(NumberParser.Parse(value));
                    case TokenType.Char:
                        Debug.Assert(value.Length == 1);
                        return new ConstantExpression(value.ToCharArray()[0]);
                    case TokenType.String:
                        return new ConstantExpression(value);
                    default:
                        throw new NotSupportedException();
                }
            }

            IExpression Variable() => new VariableExpression(Read().Value);

            TResult InParentheses<TResult>(Func<TResult> func)
            {
                Read();
                var result = func();
                Read();
                return result;
            }

            IEnumerable<IExpression> Args()
            {
                return InParentheses(() =>
                {
                    var args = new List<IExpression>();

                    while (CanRead() && !Current().IsPunctuator(")"))
                    {
                        args.Add(Expression());
                        if (Current().IsPunctuator(",")) Read();
                    }

                    return args;
                });
            }

            IExpression Call()
            {
                var t = Read();
                return new CallExpression(t.Value, Args());
            }

            IExpression Unary()
            {
                var t = Read();
                var operationType = t.Value.ToOperationType();
                return new UnaryExpression(operationType, Expression());
            }

            IExpression InitializerList()
            {
                Read(); // skip {
                var fields = new List<InitializerField>();

                while (CanRead() && !Current().IsPunctuator("}"))
                {
                    string? fieldName = null;

                    // Check for designated initializer: .field = value
                    // After tokenizer, ".field" is a single Identifier token starting with "."
                    if (Current().IsIdentifier() && Current().Value.StartsWith(".") &&
                        i + 1 < tokens.Length && tokens[i + 1].IsOperator() && tokens[i + 1].Value == "=")
                    {
                        fieldName = Current().Value.Substring(1); // remove leading "."
                        Read(); // skip .field
                        Read(); // skip =
                    }

                    fields.Add(new InitializerField { Name = fieldName, Value = Expression() });

                    if (CanRead() && Current().IsPunctuator(",")) Read();
                }

                if (CanRead() && Current().IsPunctuator("}")) Read(); // skip }

                return new InitializerListExpression(fields);
            }

            IExpression Atomic()
            {
                if (Current().IsPunctuator("{")) return InitializerList();
                if (Current().IsPunctuator("(")) return InParentheses(Expression);
                if (Current().IsConstant() || Current().IsString()) return Constant();
                if (Current().IsIdentifier())
                {
                    // NULL → null constant
                    if (Current().Value == "NULL") { Read(); return new ConstantExpression(0); }
                    return Variable();
                }
                throw new NotSupportedException();
            }

            bool IsTypeInParentheses() => IsSequenceOf(
                x => x.IsPunctuator("("),
                x => x.IsKeyword() || x.IsIdentifier(),
                x => x.IsPunctuator(")"));

            bool IsCast() => IsTypeInParentheses();

            bool IsCompoundLiteral() => IsTypeInParentheses()
                && i + 3 < tokens.Length && tokens[i + 3].IsPunctuator("{");

            IExpression CompoundLiteral()
            {
                var typeName = InParentheses(() => Read().Value);
                var init = (InitializerListExpression)InitializerList();
                return new CompoundLiteralExpression(typeName, init);
            }

            IExpression Cast() => new CastExpression(InParentheses(() => Read().Value), NoneAtomic());

            IExpression NoneAtomic()
            {
                if (CanRead())
                {
                    if (IsSequenceOf(x => x.IsIdentifier(), x => x.IsPunctuator("("))) return Call();
                    if (Current().IsOperator()) return Unary();
                    if (IsCompoundLiteral()) return CompoundLiteral();
                    if (IsCast()) return Cast();
                    return Atomic();
                }

                throw new NotSupportedException();
            }

            bool IsKnownBinaryOperator() =>
                CanRead() && Current().IsOperator() && Current().Value.TryToOperationType(out _);

            IExpression MaybeBinary(IExpression left, int precedence = int.MaxValue)
            {
                while (true)
                {
                    if (IsKnownBinaryOperator())
                    {
                        var operationType = Current().Value.ToOperationType();
                        var currentPrecedence = operationType.GetPrecedence();

                        if (currentPrecedence < precedence)
                        {
                            Read();
                            var right = MaybeBinary(NoneAtomic(), currentPrecedence);
                            var binary = new BinaryExpression(left, operationType, right);

                            left = binary;
                            continue;
                        }
                    }

                    return left;
                }
            }

            IExpression Expression() => MaybeBinary(NoneAtomic());

            return Expression();
        }
    }
}
