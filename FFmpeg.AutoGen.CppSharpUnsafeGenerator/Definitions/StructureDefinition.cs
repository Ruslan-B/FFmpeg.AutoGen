using System;
using System.Collections.Generic;
using System.Linq;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions
{
    internal record StructureDefinition : NamedDefinition, IDefinition
    {
        public StructureField[] Fields { get; set; } = System.Array.Empty<StructureField>();
        public bool IsComplete { get; set; }
        public bool IsUnion { get; init; }

        public virtual bool Equals(StructureDefinition? other) =>
            other is not null
            && base.Equals(other)
            && Fields.SequenceEqual(other.Fields)
            && EqualityComparer<bool>.Default.Equals(IsComplete, other.IsComplete)
            && EqualityComparer<bool>.Default.Equals(IsUnion, other.IsUnion);

        public override int GetHashCode()
        {
            HashCode hashcode = new();
            foreach (var item in Fields) hashcode.Add(item);
            hashcode.Add(IsComplete);
            hashcode.Add(IsUnion);
            hashcode.Add(base.GetHashCode());

            return hashcode.ToHashCode();
        }
    }
}