namespace FFmpeg.AutoGen.ClangMacroParser.Expressions
{
    public class UnaryExpression : IExpression
    {
        public UnaryExpression(OperationType operationType, IExpression operand)
        {
            OperationType = operationType;
            Operand = operand;
        }

        public OperationType OperationType { get; }

        public IExpression Operand { get; }
    }
}
