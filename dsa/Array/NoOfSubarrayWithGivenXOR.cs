using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Array
{
    public class NoOfSubarrayWithGivenXOR
    {
        //Given an array ‘A’ consisting of ‘N’ integers and an integer ‘B’, find the number of subarrays of array ‘A’ whose bitwise XOR( ^ ) of all elements is equal to ‘B
        //A subarray of an array is obtained by removing some(zero or more) elements from the front and back of the array

        //Example:
        // Input: ‘N’ = 4 ‘B’ = 2
        // ‘A’ = [1, 2, 3, 2]

        // Output: 3

        //Explanation: Subarrays have bitwise xor equal to ‘2’ are: [1, 2, 3, 2], [2], [2].

        public static void Solution(int[] nums, int xorNumber)
        {
            Console.WriteLine(NaiveSolution(nums, xorNumber));
        }

        // Time: O(n^2)
        private static int NaiveSolution(int[] nums, int xorNumber)
        {
            var n = nums.Length;
            var count = 0;

            for (int i = 0; i < n; i++)
            {
                var xor = 0;
                for (int j = i; j < n; j++)
                {
                    xor ^= nums[j];
                    if (xor == xorNumber)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
