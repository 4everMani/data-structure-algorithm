using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Array
{
    public class FindKClosestElement
    {
        //Given a sorted integer array arr, two integers k and x,
        //return the k closest integers to x in the array.
        //The result should also be sorted in ascending order.

        //An integer a is closer to x than an integer b if:

        //|a - x| < |b - x|, or
        //|a - x| == |b - x| and a < b
        //Example 1:

        //Input: arr = [1, 2, 3, 4, 5], k = 4, x = 3
        //Output: [1,2,3,4]
        //Example 2:

        //Input: arr = [1, 2, 3, 4, 5], k = 4, x = -1
        //Output: [1,2,3,4]


        public static void Solution(int[] arr, int k, int x)
        {
            //Console.WriteLine(BruteForce(arr, k, x));
            //TwoPointers(arr, k, x);
            BinarySearchSolution(arr, k, x);
        }

        private static IList<int> BruteForce(int[] arr, int k, int x)
        {
            var dict = new Dictionary<int, int>();
            IList<int> list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                var difference = Math.Abs(arr[i] - x);
                dict[i] = difference;
            }
            dict = dict.OrderBy(x => x.Value).ToDictionary();
            foreach (var item in dict)
            {
                if (list.Count < k)
                {
                    list.Add(arr[item.Key]);
                }
                else
                {
                    break;
                }
            }
            return list.Order().ToList();

        }

        private static IList<int> TwoPointers(int[] arr, int k, int x)
        {
            int start = 0;
            int end = arr.Length - 1;
            while ((end - start) >= k)
            {
                if ((x - arr[start] < arr[end] - x) || (x - arr[start] == arr[end] - x))
                {
                    end--;
                }
                else
                {
                    start++;
                }
            }

            end++;
            return arr[start..end].ToList();
        }

        private static IList<int> BinarySearchSolution(int[] arr, int k, int x)
        {
            int closetIndex = FindClosetElement(arr, x);
            int i = closetIndex - 1;
            var list = new List<int>();
            while (k > 0)
            {
                if (i < 0)
                {
                    list.Add(arr[closetIndex]);
                    closetIndex++;
                }
                else if (closetIndex >= arr.Length)
                {
                    list.Add(arr[i]);
                    i--;
                }
                else if (x - arr[i] <= arr[closetIndex] - x)
                {
                    list.Add(arr[i]);
                    i--;

                }
                else
                {
                    list.Add(arr[closetIndex]);
                    closetIndex++;
                }
                k--;
            }
            var a = arr[i..closetIndex];
            return list.Order().ToList();
        }

        private static int FindClosetElement(int[] arr, int x)
        {
            int start = 0;
            int end = arr.Length - 1;
            int maxCloeset = -1;
            int lowerClosest = -1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (arr[mid] >= x)
                {
                    maxCloeset = mid; // to find upper bound
                    end = mid - 1;
                }
                else
                {
                    lowerClosest = mid;  // to find lower bound
                    start = mid + 1;
                }
            }
            return maxCloeset;
        }
    }

}
