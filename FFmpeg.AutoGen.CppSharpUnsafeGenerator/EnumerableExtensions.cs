using System.Collections.Generic;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator
{
	internal static class EnumerableExtensions
	{
		public static void ForEach<T>(this IEnumerable<T> elements, ElementAction<T> action)
		{
			using (IEnumerator<T> enumerator = elements.GetEnumerator())
			{
				bool isFirst = true;
				bool hasNext = enumerator.MoveNext();
				int index = 0;
				while (hasNext)
				{
					T current = enumerator.Current;
					hasNext = enumerator.MoveNext();
					action(current, new ElementInfo(index, isFirst, !hasNext));
					isFirst = false;
					index++;
				}
			}
		}
	}

	internal record struct ElementInfo(int Index, bool IsFirst, bool IsLast);

	internal delegate void ElementAction<in T>(T element, ElementInfo info);
}
