namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Processors
{
    internal class Expression
    {
        public object Value { get; set; }
        public string TypeName { get; set; }

        internal class Constant : Expression
        {
        }

        internal class Group : Expression
        {
        }

        internal class Binary : Expression
        {
            public string Operator { get; set; }
            public Expression Left { get; set; }
            public Expression Right { get; set; }
        }
    }
}