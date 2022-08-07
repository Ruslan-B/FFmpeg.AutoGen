namespace FFmpeg.AutoGen.ClangMacroParser.Expressions
{
    public class CastExpression : IExpression
    {
        public CastExpression(string targetType, IExpression operand)
        {
            TargetType = targetType;
            Operand = operand;
        }

        public string TargetType { get; }

        public IExpression Operand { get; }
    }
}
