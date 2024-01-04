using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Array
{
    public class FindFirstAndLastOccuranceInSortedArray
    {

        //Given an array of integers nums sorted in non-decreasing order,
        //find the starting and ending position of a given target value.

        //If target is not found in the array, return [-1, -1].

        //You must write an algorithm with O(log n) runtime complexity.



        //Example 1:

        //Input: nums = [5, 7, 7, 8, 8, 10], target = 8
        //Output: [3,4]
        //Example 2:

        //Input: nums = [5, 7, 7, 8, 8, 10], target = 6
        //Output: [-1,-1]
        //Example 3:

        //Input: nums = [], target = 0
        //Output: [-1,-1]


        public static void Solution(int[] nums, int target)
        {
            var result = SearchRange(nums, target);
            Console.WriteLine($"startIndex: {result[0]}, lastIndex: {result[1]}.");
        }

        public static int[] SearchRange(int[] nums, int target)
        {
            if (nums.Length == 0) return new int[] { -1, -1 };
            if (nums.Length == 1 && nums[0] == target)
            {
                return new int[] { 0, 0 };
            }
            if (nums.Length == 1 && nums[0] != target)
            {
                return new int[] { -1, -1 };
            }
            int[] result = new int[] { -1, -1 };
            result[0] = Occurance(nums, target, true);
            result[1] = Occurance(nums, target, false);

            return result;
        }

        public static int Occurance(int[] nums, int target, bool isLeft)
        {
            int start = 0;
            int end = nums.Length - 1;
            int ans = -1;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (nums[mid] == target)
                {
                    ans = mid;
                    if (isLeft)
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }
                else if (nums[mid] > target)
                {
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
