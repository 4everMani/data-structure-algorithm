using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class FindMissingElementInSortedArray
    {
        // Find missing element from given array
        // elements will be from 1 to n;
        // size = n - 1

        // Example: [1, 2, 3, 4, 5, 6, 7, 9]        size = 8
        // ans = 8
        public static void Solution(int[] nums)
        {
            Console.WriteLine(BinarySearchSolution(nums));
        }

        private static int BinarySearchSolution(int[] nums)
        {
            int ans = -1;
            int start = 0;
            int end = nums.Length - 1;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (nums[mid] != mid + 1)
                {
                    ans = mid + 1;
                    end = mid - 1;

                }
                else
                {
                    start = mid + 1;
                }
            }
            return ans;
        }
    }
}
