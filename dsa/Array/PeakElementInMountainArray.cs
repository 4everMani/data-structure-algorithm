using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Array
{
    public class PeakElementInMountainArray
    {
        //An array arr is a mountain if the following properties hold:

        //arr.length >= 3
        //There exists some i with 0 < i<arr.length - 1 such that:
        //arr[0] < arr[1] < ... < arr[i - 1] < arr[i]
        //arr[i]> arr[i + 1] > ... > arr[arr.length - 1]
        //Given a mountain array arr, return the index i such that
        //arr[0] < arr[1] < ... < arr[i - 1] < arr[i] > arr[i + 1] > ... > arr[arr.length - 1].

        //You must solve it in O(log(arr.length)) time complexity.

        //Example 1:

        //Input: arr = [0, 1, 0]
        //Output: 1
        //Example 2:

        //Input: arr = [0, 2, 1, 0]
        //Output: 1
        //Example 3:

        //Input: arr = [0, 10, 5, 2]
        //Output: 1

        public static void Solution(int[] nums)
        {
            Console.WriteLine(BinarySearchSolution(nums));
        }

        public static int BinarySearchSolution(int[] nums)
        {
            int start = 0;
            int end = nums.Length - 1;
            if (nums.Length <= 2)
            {
                return end;
            }
            while (start < end)
            {
                int mid = start + (end - start) / 2;

                if (nums[mid] > nums[mid + 1])
                {
                    end = mid;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return end;
        }
    }
}
