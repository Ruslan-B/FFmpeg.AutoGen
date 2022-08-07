namespace FFmpeg.AutoGen.ClangMacroParser.Expressions
{
    public class BinaryExpression : IExpression
    {
        public BinaryExpression(IExpression left, OperationType operationType, IExpression right)
        {
            Left = left;
            OperationType = operationType;
            Right = right;
        }

        public IExpression Left { get; }
        public OperationType OperationType { get; }
        public IExpression Right { get; }
    }
}
