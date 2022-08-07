using System.Diagnostics;

namespace FFmpeg.AutoGen.ClangMacroParser.Tokenization
{
    [DebuggerDisplay("{" + nameof(Value) + "}, {" + nameof(TokenType) + "}")]
    public struct Token
    {
        public Token(TokenType tokenType, string value, int startPosition, int length)
        {
            TokenType = tokenType;
            Value = value;
            Length = length;
            StartPosition = startPosition;
        }

        public TokenType TokenType { get; }
        public string Value { get; }
        public int StartPosition { get; }
        public int Length { get; }
    }
}
