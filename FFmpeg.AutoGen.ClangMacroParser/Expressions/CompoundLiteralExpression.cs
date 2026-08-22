namespace FFmpeg.AutoGen.ClangMacroParser.Expressions
{
    /// <summary>
    /// Represents a C99 compound literal: (TypeName){ expr, expr } or (TypeName){ .field = expr }
    /// </summary>
    public class CompoundLiteralExpression : IExpression
    {
        public CompoundLiteralExpression(string typeName, InitializerListExpression initializer)
        {
            TypeName = typeName;
            Initializer = initializer;
        }

        public string TypeName { get; }

        public InitializerListExpression Initializer { get; }
    }
}
