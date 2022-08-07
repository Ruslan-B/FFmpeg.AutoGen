using FFmpeg.AutoGen.ClangMacroParser.Tokenization;

namespace FFmpeg.AutoGen.ClangMacroParser.Test
{
    [TestClass]
    public class TokenizerTest
    {
        private Token Token(TokenType tokenType, string value) => new(tokenType, value, 0, value.Length);
        private static Token[] Tokenize(string expression) => Tokenizer.Tokenize(expression).ToArray();

        private void AssertAreEqual(Token expected, Token actual)
        {
            Assert.AreEqual(expected.TokenType, actual.TokenType);
            Assert.AreEqual(expected.Value, actual.Value);
            Assert.AreEqual(expected.Length, actual.Length);
        }

        [TestMethod]
        public void Number()
        {
            AssertAreEqual(Token(TokenType.Number, ".23"), Tokenize(@".23").First());
            AssertAreEqual(Token(TokenType.Number, "1.23"), Tokenize(@"1.23").First());

            AssertAreEqual(Token(TokenType.Number, ".23f"), Tokenize(@".23f").First());
            AssertAreEqual(Token(TokenType.Number, "1.23f"), Tokenize(@"1.23f").First());

            AssertAreEqual(Token(TokenType.Number, "123"), Tokenize(@"123").First());
            AssertAreEqual(Token(TokenType.Number, "123ull"), Tokenize(@"123ull").First());

            AssertAreEqual(Token(TokenType.Number, "0xABCDEF"), Tokenize(@"0xABCDEF").First());
            AssertAreEqual(Token(TokenType.Number, "0xABCDEFull"), Tokenize(@"0xABCDEFull").First());
        }

        [TestMethod]
        public void Char()
        {
            AssertAreEqual(Token(TokenType.Char, "a"), Tokenize(@"'a'").First());
            //AssertAreEqual(Token(TokenType.Char, "\t"), Tokenize(@"'\t'").First()); // todo implement in tokenizer
            //AssertAreEqual(Token(TokenType.Char, "\'"), Tokenize(@"'\''").First());
        }

        [TestMethod]
        public void String()
        {
            AssertAreEqual(Token(TokenType.String, "abc"), Tokenize("\"abc\"").First());
            //AssertAreEqual(Token(TokenType.String, "\t"), Tokenize("\"\t\"").First()); // todo implement in tokenizer
            //AssertAreEqual(Token(TokenType.String, "\""), Tokenize("\"\"\"\"").First());
        }

        [TestMethod]
        public void MultilineFunction()
        {
            var tokens = Tokenize(@"A_B_C(A_B_C, \
                                               A_B_C)");
            Assert.AreEqual(6, tokens.Length);
            AssertAreEqual(Token(TokenType.Identifier, "A_B_C"), tokens[0]);
            AssertAreEqual(Token(TokenType.Punctuator, "("), tokens[1]);
            AssertAreEqual(Token(TokenType.Identifier, "A_B_C"), tokens[2]);
            AssertAreEqual(Token(TokenType.Punctuator, ","), tokens[3]);
            AssertAreEqual(Token(TokenType.Identifier, "A_B_C"), tokens[4]);
            AssertAreEqual(Token(TokenType.Punctuator, ")"), tokens[5]);
        }

        [TestMethod]
        public void Expression()
        {
            var tokens = Tokenize(@"-1 << 42");
            Assert.AreEqual(4, tokens.Length);
            AssertAreEqual(Token(TokenType.Operator, "-"), tokens[0]);
            AssertAreEqual(Token(TokenType.Number, "1"), tokens[1]);
            AssertAreEqual(Token(TokenType.Operator, "<<"), tokens[2]);
            AssertAreEqual(Token(TokenType.Number, "42"), tokens[3]);
        }

        [TestMethod]
        public void Call()
        {
            var tokens = Tokenize(@"TAG('A','B','C')");
            AssertAreEqual(Token(TokenType.Identifier, "TAG"), tokens[0]);
            AssertAreEqual(Token(TokenType.Punctuator, "("), tokens[1]);
            AssertAreEqual(Token(TokenType.Char, "A"), tokens[2]);
            AssertAreEqual(Token(TokenType.Punctuator, ","), tokens[3]);
            AssertAreEqual(Token(TokenType.Char, "B"), tokens[4]);
            AssertAreEqual(Token(TokenType.Punctuator, ","), tokens[5]);
            AssertAreEqual(Token(TokenType.Char, "C"), tokens[6]);
            AssertAreEqual(Token(TokenType.Punctuator, ")"), tokens[7]);
        }

        [TestMethod]
        public void Cast()
        {
            var tokens = Tokenize(@"(int)1.0f");
            AssertAreEqual(Token(TokenType.Punctuator, "("), tokens[0]);
            AssertAreEqual(Token(TokenType.Keyword, "int"), tokens[1]);
            AssertAreEqual(Token(TokenType.Punctuator, ")"), tokens[2]);
            AssertAreEqual(Token(TokenType.Number, "1.0f"), tokens[3]);
        }


        [TestMethod]
        public void ComplexIdentifier()
        {
            var tokens = Tokenize(@"A.B");
            Assert.IsTrue(tokens.Length == 1);
            AssertAreEqual(Token(TokenType.Identifier, "A.B"), tokens[0]);
        }
    }
}
