using System;
using System.Collections.Generic;
using System.Linq;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions
{
    internal record TypeDefinition : IDefinition
    {
        public string[] Attributes { get; init; } = System.Array.Empty<string>();
        public bool ByReference { get; init; }
        public string Name { get; init; }

        public virtual bool Equals(TypeDefinition? other)
        {
            return other is not null
                   && Attributes.SequenceEqual(other.Attributes)
                   && EqualityComparer<bool>.Default.Equals(ByReference, other.ByReference)
                   && EqualityComparer<string>.Default.Equals(Name, other.Name);
        }

        public override int GetHashCode()
        {
            HashCode hashcode = new();
            foreach (var item in Attributes) hashcode.Add(item);
            hashcode.Add(ByReference);
            hashcode.Add(Name);
            hashcode.Add(base.GetHashCode());

            return hashcode.ToHashCode();
        }
    }
}