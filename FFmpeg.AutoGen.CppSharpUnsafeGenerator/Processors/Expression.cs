namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Processors
{
    public class Expression
    {
        public object Value { get; set; }
        public string TypeName { get; set; }

        public class Constant : Expression
        {
        }

        public class Group : Expression
        {
        }

        public class Binary : Expression
        {
            public string Operator { get; set; }
            public Expression Left { get; set; }
            public Expression Right { get; set; }
        }
    }
}