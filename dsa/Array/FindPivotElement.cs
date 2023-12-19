using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class FindPivotElement
    {
        // Given rotated and sorted array with no duplicates.
        // Find maximum number in the array

        // Input => [9, 10, 2, 4, 6, 8]
        // Output => 10

        public static void Solution(int[] nums)
        {
            Console.WriteLine(BinarySearchSolution(nums));
        }

        public static int BinarySearchSolution(int[] nums)
        {
            int start = 0;
            int end = nums.Length - 1;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (start == end)
                {
                    return start;
                }
                if (mid + 1 <= end && nums[mid] > nums[mid+1])
                {
                    return mid;
                }
                if (mid - 1 >= start && nums[mid -1] > nums[mid])
                {
                    return mid - 1;
                }
                if (nums[start] > nums[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return -1;
        }

    }
}
