using System;

namespace Array;

public class MoveZerosToEnd
{

    // Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

    // Note that you must do this in-place without making a copy of the array.

    

    // Example 1:

    // Input: nums = [0,1,0,3,12]
    // Output: [1,3,12,0,0]
    // Example 2:

    // Input: nums = [0]
    // Output: [0]

    public static void Solution(int[] nums)
    {
        // NaiveSolution(nums);
        OptimalSolution(nums);
        foreach (var num in nums)
        {
            Console.Write(num + " ,");
        }
    }

    private static void NaiveSolution(int[] nums)
    {
        var n = nums.Length;
        var count = 0;
        for (int i = 0; i < n - count; i++)
        {
            if (nums[i] == 0)
            {
                count++;
                var j = i;
                while (j < n - 1)
                {
                    nums[j] = nums[j + 1];
                    j++;
                }
                nums[j] = 0;
            }
            if (nums[i] == 0) i--;
        }
    }

    private static void OptimalSolution(int[] nums)
    {
        var n = nums.Length;
        if (n == 1) return;
        var j = 0;
        for (int i = 0; i < n; i++)
        {
            if (nums[i] == 0)
            {
                if (nums[j] != 0) j = i;
            } 
            else if (nums[j] == 0)
            {
                (nums[j], nums[i]) = (nums[i],nums[j]);
                j++;
            }
        }
    }
}
