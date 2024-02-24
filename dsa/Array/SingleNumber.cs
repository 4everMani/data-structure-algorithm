using System;
using System.Collections.Generic;

namespace Array;

public class SingleNumber
{

    // Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.

    // You must implement a solution with a linear runtime complexity and use only constant extra space.

    

    // Example 1:

    // Input: nums = [2,2,1]
    // Output: 1
    // Example 2:

    // Input: nums = [4,1,2,1,2]
    // Output: 4
    // Example 3:

    // Input: nums = [1]
    // Output: 1

    public static void Solution(int[] nums)
    {
        System.Console.WriteLine(OptimalSolution(nums));
    }

    private static int NaiveSolution(int[] nums)
    {
        var n = nums.Length;
        if (n==1) return nums[0];

        var dict = new Dictionary<int, int>();

        for (int i = 0; i < n; i++)
        {
            if (!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i], 1);
            }
            else
            {
                dict[nums[i]] += 1;
            }
        }

        foreach(var key in dict.Keys)
        {
            if(dict[key] == 1)
            {
                return key;
            }
        }
        return -1;
    }

    private static int OptimalSolution(int[] nums)
    {
        var n = nums.Length;
        if (n==1) return nums[0];

        var uniqueElement = 0;
        for(int i = 0; i < n; i++)
        {
            uniqueElement ^= nums[i];
        }
        return uniqueElement;
    }


}
