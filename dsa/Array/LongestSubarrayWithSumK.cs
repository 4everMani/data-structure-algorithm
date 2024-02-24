using System;
using System.Collections.Generic;

namespace Array;

public class LongestSubarrayWithSumK
{
    public static void Solution(int[] nums, int target)
    {
        // int result = NaiveSolution(nums, target);
        int result = BetterSoution(nums, target);
        // int result = OptimalSolution(nums, target);

        System.Console.WriteLine(result);
    }

    // Time: O(n^2)
    private static int NaiveSolution(int[] nums, int target)
    {
        int n = nums.Length;
        int count = 0;
        int i = 0;
        while(i < n)
        {
            var sum = nums[i];
            if (sum == target)
            {
                count = 1 > count ? 1 : count;
                i += 1;
                continue;
            }
            int j = i+1;
            while(j < n)
            {
                sum += nums[j];

                if (sum < target)
                {
                    j += 1;
                }
                else if (sum == target)
                {
                    count = (j - i) + 1 > count ? (j - i) + 1: count;
                    break;
                }
                else
                {
                    break;
                }
            }
            i += 1;
        }
        return count;
    }

    // Time: O(n)
    // Space: O(n)
    // This code is known as Prefix sum and optimal solution for array containing both -ve and +ve elements.
    // But for element greater than 0, it is not optimal
    private static int BetterSoution(int[] nums, int k)
    {
        var dict = new Dictionary<long, int>();
        var sum = 0;
        var count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            if (sum == k)
            {
                count = Math.Max(count, i  +1);
            }
            if (dict.ContainsKey(sum - k))
            {
                var index = dict[sum - k];
                count = Math.Max(count, (i - index));
                
            }
            if (!dict.ContainsKey(sum)) dict.Add(sum, i);
        }
        return count;

    }

    private static int OptimalSolution(int[] nums, int k)
    {
        var sum = nums[0];
        var i = 0;
        var j = 0;
        var count = 0;
        while(j< nums.Length)
        {
            if(sum == k)
            {
                count = Math.Max(count, (j - i + 1));
                if(j >= nums.Length - 1)
                {
                    break;
                } 
                j++;
                sum += nums[j];

            }
            else if (sum < k)
            {
                j++;
                sum += nums[j];
            }
            else
            {
                sum -= nums[i];
                i++;
            }
        }
        return count;
    }
}
