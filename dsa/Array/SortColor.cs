using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Array
{
    public class SortColor
    {


        //Given an array nums with n objects colored red, white, or blue,
        //sort them in-place so that objects of the same color are adjacent,
        //with the colors in the order red, white, and blue.
        //We will use the integers 0, 1, and 2 to represent the color red,
        //white, and blue, respectively.
        //You must solve this problem without using the library's sort function.

        // Example 1:
        // Input: nums = [2,0,2,1,1,0]
        // Output: [0,0,1,1,2,2]

        // Example 2:
        // Input: nums = [2,0,1]
        // Output: [0,1,2]


        // Best approach
        public static void Solution(int[] nums)
        {
            int j = 0;

            for (int i = j; i < nums.Length; i++)
            {

                if (nums[i] == 0)
                {
                    (nums[j], nums[i]) = (nums[i], nums[j]);
                    j += 1;
                }
            }

            for (int k = j; k < nums.Length; k++)
            {
                if (nums[k] == 1)
                {
                    (nums[j], nums[k]) = (nums[k], nums[j]);
                    j += 1;
                }
            }

            for (int l = j; l < nums.Length; l++)
            {
                if (nums[l] == 2)
                {
                    (nums[j], nums[l]) = (nums[l], nums[j]);
                    j += 1;
                }
            }

            PrintArray.Print(nums);
            Console.WriteLine();
        }

        public static void OptimizedSolution(int[] nums)
        {
            var i = 0;
            var k = nums.Length - 1;
            var m = 0;

            while (m <= k)
            {
                if (nums[m] == 0)
                {
                (nums[i], nums[m]) = (nums[m], nums[i]);
                i++;
                
                }
                if (nums[m] == 2)
                {
                    (nums[k], nums[m]) = (nums[m], nums[k]);
                    k--;
                    continue;
                }
                m++;
            }

            PrintArray.Print(nums);
            Console.WriteLine();
        }
    }
}
