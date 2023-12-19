using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class SearchInRotatedArray
    {
        public static void Solution(int[] nums, int target)
        {
            // find pivot element first 
            var pivotIndex = FindPivotElement.BinarySearchSolution(nums);
            if (target >= nums[0] && target <= nums[pivotIndex])
            {
                Console.WriteLine(BinarySearch(nums, 0, pivotIndex, target));
            }
            else
            {
                Console.WriteLine(BinarySearch(nums, pivotIndex + 1, nums.Length -1, target));
            }
        
        }

        private static int BinarySearch(int[] nums, int start, int end, int target)
        {
            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] < target)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return -1;
        } 
    }
}
