using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class BinarySearch
    {
        private static int FindIndex(int[] nums, int size, int target)
        {
            var start = 0;
            var end = size - 1;

            while (start <= end)
            {
                var mid = start + (end - start) / 2;

                if (nums[mid] == target)
                {
                    return mid;

                }

                else if (nums[mid] > target)
                {
                    end = mid - 1;
                }

                else if (nums[mid] < target)
                {
                    start = mid + 1;
                }
            }
            return(-1);
        }

        public static void PrintIndex(int[] nums, int size, int target)
        {
            var index = FindIndex(nums, size, target);
            Console.WriteLine(index);
        }
    }
}
