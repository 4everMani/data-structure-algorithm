using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
namespace Array
{
    public class FinedIndexInAlmostSortedArray
    {
        //Given a sorted array arr[] of size N,
        //some elements of array are moved to either of the adjacent positions,
        //i.e., arr[i] may be present at arr[i + 1] or arr[i - 1]
        //i.e.arr[i] can only be swapped with either arr[i + 1] or arr[i - 1].
        //The task is to search for an element in this array.

        //Examples : 

        //Input: arr[] =  {10, 3, 40, 20, 50, 80, 70}, key = 40
        //Output: 2 
        //Explanation: Output is index of 40 in given array i.e. 2

        //Input: arr[] =  {10, 3, 40, 20, 50, 80, 70}, key = 90
        //Output: -1
        //Explanation: -1 is returned to indicate the element is not present


        public static void Solution(int[] nums, int target)
        {
            Console.WriteLine(BinarySolution(nums, target));
        }
        private static int BinarySolution(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (nums[mid] == target) return mid;
                else if (mid - 1 >= 0 && nums[mid - 1] == target) 
                    return mid - 1;
                else if (mid + 1 < nums.Length  && nums[mid + 1] == target) 
                    return mid + 1;

                else if (nums[mid] > target) 
                    end = mid - 2; // coz we have already checked element at mid - 1, so we will not visit again
                else 
                    start = mid + 2; // coz we have already checked element at mid + 1, so we will not visit again
            }
            return -1;
        }
    }
}
