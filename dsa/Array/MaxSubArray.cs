using System;

namespace Array;

public class MaxSubArray
{
    public static void Solution(int[] nums)
    {
        int result = OptimalSoluiton(nums);
        Console.WriteLine(result);
    }

     // Time: O(n^3)
    private static int NaiveSolution(int[] nums)
    {
        var maxSum = int.MinValue;

        for (int i = 0; i < nums.Length; i++)
        {
           
            for (int j = i; j < nums.Length; j++)
            {
                var tempSum = 0;
                for (int k = j; k < nums.Length; k++)
                {
                    tempSum += nums[k];   
                    maxSum = Math.Max(tempSum, maxSum);
                }
            }
        }
        return maxSum;
    }

     // Time: O(n^2)
    private static int BetterSolution(int[] nums)
    {
        var maxSum = int.MinValue;

        for (int i = 0; i < nums.Length; i++)
        {
            var tempSum = 0;
            for (int j = i; j < nums.Length; j++)
            {
                tempSum += nums[j];
                maxSum = Math.Max(tempSum, maxSum);
            }
        }
        return maxSum;
    }

    // Kadan's algorithm
    // iterate through array and if sum < 0, mark sum as 0.
    // Time: O(n)
    private static int OptimalSoluiton(int[] nums)
    {
        int maxValue = int.MinValue;
        int sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            maxValue = Math.Max(maxValue, sum);
            if (sum < 0) sum = 0;
        }
        return maxValue;
    }
}
