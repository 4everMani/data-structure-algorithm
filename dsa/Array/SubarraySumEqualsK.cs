using System;
using System.Collections.Generic;

namespace Array;

public class SubarraySumEqualsK
{

    // Given an array of integers nums and an integer k, return the total number of subarrays whose sum equals to k.
    // A subarray is a contiguous non-empty sequence of elements within an array.

    // Example 1:
    // Input: nums = [1,1,1], k = 2
    // Output: 2

    // Example 2:
    // Input: nums = [1,2,3], k = 3
    // Output: 2

    public static void Solution(int[] nums, int k)
    {
        int result = NaiveSolution(nums, k);
        System.Console.WriteLine(result);
    }

    private static int NaiveSolution(int[] nums, int k)
    {
        var count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            var sum = 0;
            for (int j = i; j < nums.Length; j++)
            {
                sum += nums[j];
                if (sum == k) count ++;
            }
        }
        return count;
    }

    private static int OptimalSolution(int[] nums, int k)
    {
        var set = new HashSet<int>();
        int sum = 0;
        int i = 0;
        int j = 0;
        int count = 0;

        while(j < nums.Length)
        {
            sum += nums[j];
            if (set.Contains(sum - k))
            {
                count++;
                sum -= nums[i];
                i++;
            }
            else
            {
                set.Add(sum);
            }
            j++;
        }
        return count;
    }
}
