
using System.Formats.Asn1;

namespace Backtracking;

public class PartitionEqualSubsetSum
{

    // Given an integer array nums, return true if you can partition the array into two subsets 
    // such that the sum of the elements in both subsets is equal or false otherwise.   

    // Example 1:
    // Input: nums = [1,5,11,5]
    // Output: true
    // Explanation: The array can be partitioned as [1, 5, 5] and [11].
    
    // Example 2:
    // Input: nums = [1,2,3,5]
    // Output: false
    // Explanation: The array cannot be partitioned into equal sum subsets.


    public static void Solution(int[] nums)
    {
    //    System.Console.WriteLine(CanPartition(nums));
       CanPartitionII(nums);
    }

    public static bool CanPartition(int[] nums) {
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        if (sum % 2 != 0) return false;
       return Helper(nums, 0, sum/2);
    }

    // Subset sum problem using recursion
    private static bool Helper(int[] nums, int index, int target)
    {
        // base case
        if (index >= nums.Length) return false;

        // checking if target is found
        else if (target == 0) return true;

        // Picking
        else if (Helper(nums, index + 1, target - nums[index])) return true;

        // Not picking
        else if (Helper(nums, index + 1, target)) return true;
        return false;
    }

    // Subset sum problem using recursion and memoization
    private static bool HelperII(int[] nums, int index, int target, int[][] dp)
    {
        // base case
        if (index >= nums.Length) return false;

        // checking if target is found
        else if (target == 0) return true;

        else if (target < 0) return false;

        else if (dp[index][target] != -1) return dp[index][target] == 1 ? true : false;

        // Picking
        else if (HelperII(nums, index + 1, target - nums[index], dp))
        {
            dp[index][target] = 1;
            return true;
        } 

        // Not picking
        else if (HelperII(nums, index + 1, target, dp)) 
        {
            dp[index][target] = 1;
            return true;
        } 
        dp[index][target] = 0;
        return false;
    }

    public static bool CanPartitionII(int[] nums) 
    {
        int sum = 0;

        // each index will work as row
        // each target will work as column
        // ex: index = 2 and target is 6
        // row 3rd, column from 0 to 6(coz target can be between 0 to 6)
        int[][] dp = new int[nums.Length][];
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        if (sum % 2 != 0) return false;
        int target = sum / 2;
        for (int j = 0; j < nums.Length; j++)
        {
            dp[j] = new int[target + 1];
            Array.Fill(dp[j], -1);
        }
    //    return HelperII(nums, 0, sum/2, dp);
    return HelperIIII(nums, target);
    }

    // Subset sum problem using iterative solution
    private static bool HelperIIII(int[] nums, int target)
    {
        bool[][] dp = new bool[nums.Length][];

        // initialising 2-D array and inserting initial values
        for(int m = 0; m < nums.Length; m++)
        {
            dp[m] = new bool[target + 1];
            dp[m][0] = true;
        }
        for (int j = 0; j <= target; j++)
        {
            if (nums[0] == j) dp[0][j] = true;
        }
        

        // looping through 2-D array
        int i = 1;
        for (; i < nums.Length; i++)
        {
            for (int j = 1; j <= target; j++)
            {
                if (j >= nums[i])
                {
                    dp[i][j] = dp[i-1][j - nums[i]];
                }
                dp[i][j] = dp[i][j] || dp[i - 1][j];
            }
        }

        return dp[i - 1][target];
    }
}
