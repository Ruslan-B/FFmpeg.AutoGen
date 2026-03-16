using System.Collections.Generic;

namespace FFmpeg.AutoGen.ClangMacroParser.Expressions
{
    /// <summary>
    /// Represents a C initializer list: { expr, expr } or { .field = expr, .field = expr }
    /// </summary>
    public class InitializerListExpression : IExpression
    {
        public InitializerListExpression(IEnumerable<InitializerField> fields)
        {
            Fields = new List<InitializerField>(fields);
        }

        public List<InitializerField> Fields { get; }
    }

    public class InitializerField
    {
        /// <summary>
        /// Field name for designated initializers (.field = value). Null for positional.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The value expression.
        /// </summary>
        public IExpression Value { get; set; }
    }
}
