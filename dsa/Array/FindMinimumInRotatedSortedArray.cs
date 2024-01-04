using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
namespace Array
{
    public class FindMinimumInRotatedSortedArray
    {

        //Suppose an array of length n sorted in ascending order is rotated between 1 and n times.
        //For example, the array nums = [0, 1, 2, 4, 5, 6, 7] might become:
        //[4,5,6,7,0,1,2] if it was rotated 4 times.
        //[0, 1, 2, 4, 5, 6, 7] if it was rotated 7 times.
        //Notice that rotating an array[a[0], a[1], a[2], ..., a[n - 1]] 1 time results in the array[a[n - 1], a[0], a[1], a[2], ..., a[n - 2]].

        //Given the sorted rotated array nums of unique elements, return the minimum element of this array.
        //You must write an algorithm that runs in O(log n) time.

        //Example 1:

        //Input: nums = [3,4,5,1,2]
        //Output: 1
        //Explanation: The original array was[1, 2, 3, 4, 5] rotated 3 times.


        public static void Solution(int[] nums)
        {
            Console.WriteLine(FindMin(nums));
        }

        public static int FindMin(int[] nums)
        {
            if (nums.Length == 1) return nums[0];
            if (nums[0] < nums[1] && nums[0] < nums[nums.Length - 1]) return nums[0];
            int start = 0;
            int end = nums.Length - 1;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (mid - 1 >= 0 && nums[mid] < nums[mid - 1])
                {
                    return nums[mid];
                }
                else if (nums[mid] <= nums[end])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return nums[start];
        }
    }
}
