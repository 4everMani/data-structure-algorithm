using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
namespace Array
{
    public class PivotIndex
    {
        //Given an array of integers nums, calculate the pivot index of this array.

        //The pivot index is the index where the sum of all the numbers strictly to the left of the index is equal
        //to the sum of all the numbers strictly to the index's right.

        //If the index is on the left edge of the array, then the left sum is 0 because there are no elements to the left.
        //This also applies to the right edge of the array.

        //Return the leftmost pivot index.If no such index exists, return -1.

        //Input: nums = [1,7,3,6,5,6]
        //Output: 3
        //Explanation:
        //The pivot index is 3.
        //Left sum = nums[0] + nums[1] + nums[2] = 1 + 7 + 3 = 11
        //Right sum = nums[4] + nums[5] = 5 + 6 = 11

        public static void Solution(int[] nums)
        {
            //BruteForce(nums);
            Improved(nums);


        }

        private static void BruteForce(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                // left side sum
                for (int j = 0; j < i; j++)
                {
                    leftSum += nums[j];
                }

                // right side sum 
                for (int k = i + 1; k < nums.Length; k++)
                {
                    rightSum += nums[k];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine(-1);
        }

        private static void Improved(int[] nums)
        {
            int totalSum = 0;
            int leftSum = 0;
            for (int i = 0; i < nums.Length;i++)
            {
                totalSum += nums[i];
            }

            for (int k = 0; k < nums.Length; k++)
            {
                leftSum += k > 0 ? nums[k - 1] : 0;
                int rightSum = totalSum - leftSum - nums[k];
                if (leftSum == rightSum)
                {
                    Console.WriteLine(k);
                    return;
                }

            }
            Console.WriteLine(-1);


        }
    }
}
