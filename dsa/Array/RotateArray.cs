using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Array
{
    public class RotateArray
    {

        // Given an integer array nums, rotate the array to the right by k steps, where k is non-negative.



        //Example 1:

        //Input: nums = [1,2,3,4,5,6,7], k = 3
        //Output: [5,6,7,1,2,3,4]
        //Explanation:
        //rotate 1 steps to the right: [7,1,2,3,4,5,6]
        //rotate 2 steps to the right: [6,7,1,2,3,4,5]
        //rotate 3 steps to the right: [5,6,7,1,2,3,4]


        // naive approach
        //public void Rotate(int[] nums, int k)
        //{
        //    for (int i = 1; i <= k; i++)
        //    {
        //        int right = nums.Length - 1;
        //        var temp = nums[right];

        //        while (right > 0)
        //        {
        //            nums[right] = nums[right - 1];
        //            right -= 1;
        //        }
        //        nums[right] = temp;

        //    }
        //}

        public static void Rotate(int[] nums, int k)
        {
            int[] arr = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                int newIndex = (i + k) % nums.Length;
                arr[newIndex] = nums[i];

            }
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = arr[i];

            }
        }
    }
}
