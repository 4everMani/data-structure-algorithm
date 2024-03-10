using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Array
{
    public class SubarraySumEquals_K
    {
        //Given an array of integers nums and an integer k, return the total number of subarrays whose sum equals to k
        //A subarray is a contiguous non-empty sequence of elements within an array.

        //Example 1
        //Input: nums = [1, 1, 1], k = 2
        //Output: 2

        //Example 2
        //Input: nums = [1, 2, 3], k = 3
        //Output: 2


        public static void Solution(int[] nums, int k)
        {
            int res = OptimalSolution(nums, k):
        }

        private static int OptimalSolution(int[] nums, int k)
        {
            var dict = new Dictionary<int, int>();
            var preSum = 0;
            var count = 0;

            dict.Add(0, 1);

            for (int i = 0; i < nums.Length; i++)
            {
                preSum += nums[i];

                var remove = preSum - k;

                if (dict.ContainsKey(remove))
                {
                    count += dict.GetValueOrDefault(remove);
                }
                if (dict.ContainsKey(preSum))
                {
                    dict[preSum] += 1;
                }
                else
                {
                    dict.Add(preSum, 1);
                }
                                
            }
            return count;
        }
    }
}
