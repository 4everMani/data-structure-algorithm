using System;
using System.Collections.Generic;
using System.Linq;

namespace Array;

public class LongestSuccessiveElements
{

    // There is an integer array ‘A’ of size ‘N’.
    // A sequence is successive when the adjacent elements of the sequence have a difference of 1.
    // You must return the length of the longest successive sequence.
    // Note:
    // You can reorder the array to form a sequence. 
    // For example,
    // Input:
    // A = [5, 8, 3, 2, 1, 4], N = 6
    // Output:
    // 5
    // Explanation: 
    // The resultant sequence can be 1, 2, 3, 4, 5.    
    // The length of the sequence is 5.

    public static void Solution(int[] nums)
    {
        int result = OptimalSolution(nums);
        System.Console.WriteLine(result);
    }

    private static int OptimalSolution(int[] nums)
    {
        nums = nums.Order().ToArray();
        int maxCount = int.MinValue;
        int count = 1;

        for(int i = 1; i < nums.Length; i++)
        {
            if (nums[i] - nums[i - 1] == 1)
            {
                count++;
            }
            else if (nums[i] == nums[i - 1]) continue;
            else
            {
                maxCount = Math.Max(count, maxCount);
                count = 1;
            }
        }
        return Math.Max(maxCount, count);
    }
}
