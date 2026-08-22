using System;
using System.Collections.Generic;
using System.Linq;

namespace FFmpeg.AutoGen.ClangMacroParser.Tokenization
{
    public static class Tokenizer
    {
        private static readonly HashSet<char> Digits = new("0123456789");
        private static readonly HashSet<char> HexDigits = new("abcdef");
        private static readonly HashSet<char> Separators = new(" \\\r\n\t");
        private static readonly HashSet<char> NumberEnd = new("ulfd");
        private static readonly HashSet<char> Operators = new("+-*/<>=|~!^&#");
        private static readonly HashSet<char> Punctuators = new(",()[]{}");

        private static readonly HashSet<string> Keywords = new()
        {
            "auto", "break", "case", "char", "const", "continue", "default", "do", "double", "else", "enum", "extern", "float",
            "for", "goto", "if", "int", "long", "register", "return", "short", "signed", "sizeof", "static", "struct", "switch",
            "typedef", "union", "unsigned", "void", "volatile", "while"
        };

        public static IEnumerable<Token> Tokenize(string expression)
        {
            bool IsAz(char x) => char.ToLowerInvariant(x) >= 'a' && char.ToLowerInvariant(x) <= 'z';
            bool IsQuote(char x) => x == '\'';
            bool IsDoubleQuote(char x) => x == '"';
            bool IsNumberStart(char x) => x == '.' || Digits.Contains(x);
            bool IsNumberBody(char x) => IsNumberStart(x) || char.ToLowerInvariant(x) == 'x' || HexDigits.Contains(char.ToLowerInvariant(x));
            bool IsNumberEnd(char x) => NumberEnd.Contains(char.ToLowerInvariant(x));
            bool IsIdentifierStart(char x) => x == '_' || IsAz(x);
            bool IsId(char x) => IsIdentifierStart(x) || Digits.Contains(x) || x == '.';

            char[] characters = expression.ToCharArray();
            var i = 0;

            bool CanRead() => i < characters.Length;
            char Current() => characters[i];
            char Read() => characters[i++];


            IEnumerable<char> YieldWhile(params Func<char, bool>[] tests)
            {
                foreach (var test in tests)
                    while (CanRead() && test(Current()))
                        yield return Read();
            }

            Token Token(TokenType type, IEnumerable<char> x)
            {
                var s = new string(x.ToArray());
                return new Token(type, s, i - s.Length, s.Length);
            }

            Token OneCharToken(TokenType type, char x) => Token(type, new[] { x });

            void Skip(Func<char, bool> test)
            {
                while (CanRead() && test(Current())) Read();
            }

            Token Number() => Token(TokenType.Number, YieldWhile(IsNumberStart, IsNumberBody, IsNumberEnd));

            Token IdentifierOrKeyword()
            {
                var value = new string(YieldWhile(IsIdentifierStart, IsId).ToArray());
                return Token(Keywords.Contains(value) ? TokenType.Keyword : TokenType.Identifier, value);
            }

            Token String()
            {
                //todo is not complete as escape double quote and double double quote needs to be handled
                Skip(IsDoubleQuote);
                var t = Token(TokenType.String, YieldWhile(x => !IsDoubleQuote(x)));
                Skip(IsDoubleQuote);
                return t;
            }

            Token Char()
            {
                //todo is not complete as escape quote needs to be handled
                Skip(IsQuote);
                var t = Token(TokenType.Char, YieldWhile(x => !IsQuote(x)));
                Skip(IsQuote);
                return t;
            }

            Token Operator() => Token(TokenType.Operator, YieldWhile(Operators.Contains));

            Token Punctuator()
            {
                var c = Read();

                switch (c)
                {
                    case ',': return OneCharToken(TokenType.Punctuator, c);
                    case '(': return OneCharToken(TokenType.Punctuator, c);
                    case ')': return OneCharToken(TokenType.Punctuator, c);
                    case '[': return OneCharToken(TokenType.Punctuator, c);
                    case ']': return OneCharToken(TokenType.Punctuator, c);
                    case '{': return OneCharToken(TokenType.Punctuator, c);
                    case '}': return OneCharToken(TokenType.Punctuator, c);
                    default:
                        throw new NotSupportedException();
                }
            }

            while (CanRead())
            {
                var c = Current();

                if (Separators.Contains(c)) Skip(Separators.Contains);
                else if (c == '/' && i + 1 < characters.Length && characters[i + 1] == '*')
                {
                    // Skip C-style comments /* ... */
                    Read(); Read(); // skip /*
                    while (CanRead() && !(Current() == '*' && i + 1 < characters.Length && characters[i + 1] == '/'))
                        Read();
                    if (CanRead()) { Read(); Read(); } // skip */
                }
                else if (c == '.' && i + 1 < characters.Length && IsIdentifierStart(characters[i + 1]))
                {
                    // Designated initializer field: .field or .u.mask
                    var startPos = i;
                    Read(); // consume '.'
                    var value = "." + new string(YieldWhile(IsIdentifierStart, IsId).ToArray());
                    yield return new Token(TokenType.Identifier, value, startPos, value.Length);
                }
                else if (IsNumberStart(c))
                {
                    var num = Number();
                    // Handle tokens like 0BGR, 0RGB where digit-prefixed identifiers
                    // are used as macro arguments (e.g. AV_PIX_FMT_NE(0BGR, RGB0))
                    if (CanRead() && IsIdentifierStart(Current()))
                    {
                        var rest = new string(YieldWhile(IsIdentifierStart, IsId).ToArray());
                        yield return Token(TokenType.Identifier, num.Value + rest);
                    }
                    else
                    {
                        yield return num;
                    }
                }
                else if (IsIdentifierStart(c)) yield return IdentifierOrKeyword();
                else if (IsDoubleQuote(c)) yield return String();
                else if (IsQuote(c)) yield return Char();
                else if (Operators.Contains(c)) yield return Operator();
                else if (Punctuators.Contains(c)) yield return Punctuator();
                else throw new NotSupportedException();
            }
        }
    }
}
