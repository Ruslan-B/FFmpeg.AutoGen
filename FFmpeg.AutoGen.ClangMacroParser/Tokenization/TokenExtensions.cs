namespace FFmpeg.AutoGen.ClangMacroParser.Tokenization
{
    public static class TokenExtensions
    {
        public static bool IsIdentifier(this Token token) =>
            token.TokenType == TokenType.Identifier;

        public static bool IsOperator(this Token token) =>
            token.TokenType == TokenType.Operator;

        public static bool IsConstant(this Token token) =>
            token.TokenType == TokenType.Number || token.TokenType == TokenType.Char || token.TokenType == TokenType.String;

        public static bool IsKeyword(this Token token) =>
            token.TokenType == TokenType.Keyword;

        public static bool IsString(this Token token) =>
            token.TokenType == TokenType.String;

        public static bool IsPunctuator(this Token token, string value) =>
            token.TokenType == TokenType.Punctuator && token.Value == value;
    }
}
