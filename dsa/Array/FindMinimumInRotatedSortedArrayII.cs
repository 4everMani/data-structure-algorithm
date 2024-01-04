using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
namespace Array
{
    public class FindMinimumInRotatedSortedArrayII
    {

        //Suppose an array of length n sorted in ascending order is rotated between 1 and n times.
        //For example, the array nums = [0, 1, 4, 4, 5, 6, 7] might become:

        //[4,5,6,7,0,1,4] if it was rotated 4 times.
        //[0, 1, 4, 4, 5, 6, 7] if it was rotated 7 times.
        //Notice that rotating an array[a[0], a[1], a[2], ..., a[n - 1]] 1 time results in the array[a[n - 1], a[0], a[1], a[2], ..., a[n - 2]].

        //Given the sorted rotated array nums that may contain duplicates,
        //return the minimum element of this array.
        //You must decrease the overall operation steps as much as possible.



        //Example 1:
        //Input: nums = [1,3,5]
        //        Output: 1
        //Example 2:
        //Input: nums = [2,2,2,0,1]
        //        Output: 0



        public static void Solution(int[] nums)
        {
            Console.WriteLine(FindMin(nums));
        }
        public static int FindMin(int[] nums)
        {
            if (nums.Length == 1) return nums[0];
            int start = 0;
            int end = nums.Length - 1;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (mid - 1 >= 0 && nums[mid] < nums[mid - 1])
                {
                    return nums[mid];
                }
                else if (nums[mid] == nums[end])
                {
                    end = end - 1;
                }
                else if (nums[mid] < nums[end])
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
