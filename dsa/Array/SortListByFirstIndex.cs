using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class SortListByFirstIndex
    {
        public static void Solution()
        {
            var list = new List<List<int>>
            {
                new() { 1, 44 },
                new() { 0, 55 },
                new() { 0, 22 },
                new() { 0, 11 },
                new() { 2, 33 },
            };

            Sort(list);
            foreach (var item in list)
            {
                Console.WriteLine(item[0] + " " + item[1]);
            }

        }

        public static void Sort(List<List<int>> list)
        {
            var customComparer = new Comparer();
            list.Sort(customComparer);
        }
    }

    public class Comparer : IComparer<List<int>>
    {
        
        public int Compare(List<int>? x, List<int>? y)
        {
            return x[1].CompareTo(y[1]);
        }
    }
}
