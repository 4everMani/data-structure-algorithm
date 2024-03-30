using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
namespace BinarySearch
{
    public class SearchInsertPosition
    {
        //Given a sorted array of distinct integers and a target value,
        //return the index if the target is found.If not, return the index where it would be if it were inserted in order.

        //You must write an algorithm with O(log n) runtime complexity.



        //Example 1:

        //Input: nums = [1, 3, 5, 6], target = 5
        //Output: 2
        //Example 2:

        //Input: nums = [1, 3, 5, 6], target = 2
        //Output: 1
        //Example 3:

        //Input: nums = [1, 3, 5, 6], target = 7
        //Output: 4


        public static void Solution(int[] nums, int target)
        {
            Console.WriteLine(SearchInsert(nums, target));
        }

        private static int SearchInsert(int[] nums, int target)
        {

            int idx = nums.Length - 1;
            if (target > nums[idx]) return nums.Length;
            int start = 0;
            int end = idx;

            while (start <= end)
            {
                var mid = start + (end - start) / 2;
                if (nums[mid] >= target && nums[mid] <= nums[idx])
                {
                    idx = mid;
                    end = mid - 1;
                }
                else if (nums[mid] < target)
                {
                    start = mid + 1;
                }
                else end = mid - 1;
            }
            return idx;
        }
    }
}
