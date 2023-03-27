using System.Runtime.Intrinsics.X86;

namespace BubbleSort
{
    public static class SortExtension
    {
        public static void BubbleSort<T>(this List<T> list) where T : IComparable
        {
            for (int step = 0; step < list.Count; step++)
            {
                for (int sort = 0; sort < list.Count - step - 1; sort++)
                {
                    if (list[sort].CompareTo(list[sort + 1]) > 0)
                    {
                        (list[sort], list[sort + 1]) = (list[sort + 1], list[sort]);
                    }
                }
            }
        }
    }
}
