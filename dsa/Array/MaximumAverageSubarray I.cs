using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class MaximumAverageSubarray_I
    {


        //You are given an integer array nums consisting of n elements,
        //and an integer k.

        //Find a contiguous subarray whose length is equal to k that
        //has the maximum average value and return this value.
        //Any answer with a calculation error less than 10-5 will be
        //accepted.



        //Example 1:

        //Input: nums = [1, 12, -5, -6, 50, 3], k = 4
        //Output: 12.75000
        //Explanation: Maximum average is (12 - 5 - 6 + 50) / 4 = 51 / 4 = 12.75


        public static void Solution(int[] nums, int k)
        {

            var maxSum = double.MinValue;
            var sum = 0;
            for (int l =0; l < k ; l++)
            {
                sum += nums[l];
            }
            maxSum = Math.Max(sum, maxSum);
            int i = 1;
            int j = k;
            while (j < nums.Length)
            {
                sum = sum + nums[j] - nums[i - 1];
                maxSum = Math.Max(sum, maxSum);
                i++;
                j++;
            }
            Console.Write(maxSum / (double)k);
        }


        public static void Solution1(int[] nums, int k)
        {
            double avg = 0.00;

            int i = 0;
            int j = k - 1;

            while (j < nums.Length)
            {
                var sum = 0;
                for (int m = i; m <= j; m++)
                {
                    sum += nums[m];
                }
                var tempAvg = (sum / (double)k);
                if (avg < tempAvg)
                {
                    avg = tempAvg;
                }
                i++;
                j++;
            }
            Console.Write(avg);
        }
    }
}
