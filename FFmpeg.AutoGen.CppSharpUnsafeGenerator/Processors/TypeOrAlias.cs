using System;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Processors
{
    internal class TypeOrAlias
    {
        public TypeOrAlias(Type type)
        {
            Type = type;
            Precedence = GetPrecedence();
        }

        public TypeOrAlias(string alias) => Alias = alias;

        public bool IsType => Alias != null;
        public bool IsAlias => Alias != null;
        public Type Type { get; }
        public string Alias { get; }
        public int Precedence { get; }

        private int GetPrecedence()
        {
            if (Type == typeof(bool)) return 0;
            if (Type == typeof(double)) return 1;
            if (Type == typeof(float)) return 2;
            if (Type == typeof(ulong)) return 3;
            if (Type == typeof(long)) return 4;
            if (Type == typeof(uint)) return 5;
            if (Type == typeof(int)) return 6;
            if (Type == typeof(char)) return 7;
            if (Type == typeof(string)) return 8;
            return int.MaxValue;
        }

        public override string ToString()
        {
            if (Type == typeof(bool)) return "bool";
            if (Type == typeof(double)) return "double";
            if (Type == typeof(float)) return "float";
            if (Type == typeof(char)) return "char";
            if (Type == typeof(string)) return "string";
            if (Type == typeof(long)) return "long";
            if (Type == typeof(ulong)) return "ulong";
            if (Type == typeof(int)) return "int";
            if (Type == typeof(uint)) return "uint";
            return Alias;
        }

        public static implicit operator TypeOrAlias(Type type) => new TypeOrAlias(type);
        public static implicit operator TypeOrAlias(string alias) => new TypeOrAlias(alias);
    }
}