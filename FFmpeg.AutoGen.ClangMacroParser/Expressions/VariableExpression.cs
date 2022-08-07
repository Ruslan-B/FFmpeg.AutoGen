namespace FFmpeg.AutoGen.ClangMacroParser.Expressions
{
    public class VariableExpression : IExpression
    {
        public VariableExpression(string name) => Name = name;

        public string Name { get; }
    }
}
