namespace BubbleSort
{
    public static class SortExtension
    {
        public static void BubbleSort<T>(this List<T> list) where T : IComparable
        {
            for (int step = 0; step < list.Count; step++)
            {
                var orderPairsCount = list.Count - step - 1;
                list.OrderOpeningPairs(orderPairsCount);
            }
        }

        private static void OrderOpeningPairs<T>(this List<T> list, int amount) where T : IComparable
        {
            for (int i = 0; i < amount; i++)
            {
                OrderWithSubsequent(list, i);
            }
        }

        private static void OrderWithSubsequent<T>(List<T> list, int index) where T : IComparable
        {
            if (list[index].CompareTo(list[index + 1]) > 0)
            {
                (list[index], list[index + 1]) = (list[index + 1], list[index]);
            }
        }
    }
}
