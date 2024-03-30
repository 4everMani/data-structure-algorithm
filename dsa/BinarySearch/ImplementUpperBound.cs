using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace BinarySearch
{
    public class ImplementUpperBound
    {

        // Question: https://www.codingninjas.com/studio/problems/implement-upper-bound_8165383?utm_source=striver&utm_medium=website&utm_campaign=a_zcoursetuf

        //You are given a sorted array ‘arr’ containing ‘n’ integers and an integer ‘x’.

        //Implement the ‘upperBound’ function to find the index of the upper bound of 'x' in the array.
        //        Note:
        //The upper bound in a sorted array is the index of the first value that is greater than a given value.
        //If the greater value does not exist then the answer is 'n', Where 'n' is the size of the array.
        //We are using 0-based indexing.
        //Try to write a solution that runs in log(n) time complexity.


        //Example:
        //Input : ‘arr’ = { 2,4,6,7}
        //    and ‘x’ = 5,
        //Output: 2


        public static void Solution(int[] nums, int x)
        {
            var result = UpperBound(nums, x);
            Console.WriteLine(result);
        }

        private static int UpperBound(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;
            int idx = end;

            if (target >= nums[end]) return nums.Length;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if ((nums[mid] > target))
                {
                    idx = mid;
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return idx;
        }
    }
}
