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

            IExpression Atomic()
            {
                if (Current().IsPunctuator("(")) return InParentheses(Expression);
                if (Current().IsConstant() || Current().IsString()) return Constant();
                if (Current().IsIdentifier()) return Variable();
                throw new NotSupportedException();
            }

            bool IsCast() => IsSequenceOf(x => x.IsPunctuator("("), x => x.IsKeyword() || x.IsIdentifier(), x => x.IsPunctuator(")"));

            IExpression Cast() => new CastExpression(InParentheses(() => Read().Value), NoneAtomic());

            IExpression NoneAtomic()
            {
                if (CanRead())
                {
                    if (IsSequenceOf(x => x.IsIdentifier(), x => x.IsPunctuator("("))) return Call();
                    if (Current().IsOperator()) return Unary();
                    if (IsCast()) return Cast();
                    return Atomic();
                }

                throw new NotSupportedException();
            }

            IExpression MaybeBinary(IExpression left, int precedence = int.MaxValue)
            {
                while (true)
                {
                    if (CanRead() && Current().IsOperator())
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
