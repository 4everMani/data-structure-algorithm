using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    //public class FindKthPositiveMissingElement
    //{
    //}
    public class FindKthPositiveMissingElement
    {
        public static void Solution(int[] nums, int k)
        {
            //Console.WriteLine(FindKthPositive(nums, k));
            Console.WriteLine(BinarySolution(nums, k));
        }

        // O(n) (1)
        private static int FindKthPositive(int[] arr, int k)
        {
            int num = 0;
            if (arr[0] > 1)
            {
                k -= arr[0] - 1;
                num = arr[0] - 1;
                if (k <= 0) return num + k;
            }
            for (int i = 1; i < arr.Length; i++)
            {

                int diff = arr[i] - arr[i - 1];
                k -= diff - 1;
                num = arr[i - 1] + diff - 1;
                if (k <= 0) return num + k;
            }
            if (k != 0)
            {
                num = arr[^1] + k; // arr[arr.Length - 1] + k
            }
            return num;
        }

        private static int BinarySolution(int[] arr, int k)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                int missingElement = arr[mid] - (mid + 1);
                if (missingElement > k)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            int a = k - (arr[end] - (end + 1));
            return arr[end] + a;
        }
    }
}
