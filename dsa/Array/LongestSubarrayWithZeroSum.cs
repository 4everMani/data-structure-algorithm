using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class LongestSubarrayWithZeroSum
    {

            //Ninja is given an array ‘Arr’ of size ‘N’. You have to help him find the longest subarray of ‘Arr’, whose sum is 0. 
            //You must return the length of the longest subarray whose sum is 0.

            //For Example:
            //For N = 5, and Arr = {1, -1, 0, 0, 1}, 
            //We have the following subarrays with zero sums: 
            //{{1, -1}, {1, -1, 0}, { 1, -1, 0, 0}, { -1, 0, 0, 1}, { 0}, { 0, 0}, { 0}}
            //Among these subarrays, {1, -1, 0, 0} and {-1, 0, 0, 1} are the longest subarrays with their sum equal to zero. Hence the answer is 4.

        public static void Solution(int[] nums)
        {
            int longestSubarrayCount = NaiveSolution(nums);
            Console.WriteLine(longestSubarrayCount);
        }

        // Time: O(n^2)
        private static int NaiveSolution(int[] nums)
        {
            int n = nums.Length;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                var sum = nums[i];
                for (int j = i; j < n; j++)
                {
                    sum = i == j ? sum : sum + nums[j];
                    if (sum == 0)
                    {
                        var difference = j - i + 1;
                        count = Math.Max(count, difference);
                    }
                }
            }
            return count;
        }

        
    }
}
