namespace Recursion;

public class HouseRob
{
    // You are a professional robber planning to rob houses along a street. 
    // Each house has a certain amount of money stashed, the only constraint 
    // stopping you from robbing each of them is that adjacent houses have security systems 
    // connected and it will automatically contact the police if two adjacent houses were broken into on the same night.

    // Given an integer array nums representing the amount of money of each house, return the maximum 
    //amount of money you can rob tonight without alerting the police.

    // Example 1:
    // Input: nums = [1,2,3,1]
    // Output: 4
    // Explanation: Rob house 1 (money = 1) and then rob house 3 (money = 3).
    // Total amount you can rob = 1 + 3 = 4.
    
    // Example 2:
    // Input: nums = [2,7,9,3,1]
    // Output: 12
    // Explanation: Rob house 1 (money = 2), rob house 3 (money = 9) and rob house 5 (money = 1).
    // Total amount you can rob = 2 + 9 + 1 = 12.

    public static void Solution(int[] nums)
    {
        System.Console.WriteLine(Rob(nums));
    }
   
    public static int Rob(int[] nums) {
        // return GetMaximum(nums, 0);
        return GetMaximum2(nums, nums.Length - 1);
    }

    private static int GetMaximum(int[] nums, int n)
    {
        if (n > nums.Length - 1) return 0;
        var picked = nums[n] + GetMaximum(nums, n + 2);
        var notPicked = GetMaximum(nums, n + 1);
        return Math.Max(picked, notPicked);
    }

    private static int GetMaximum2(int[] nums, int n)
    {
        if (n < 0) return 0;
        var picked = nums[n] + GetMaximum2(nums, n - 2);
        var notPicked = GetMaximum2(nums, n - 1);
        return Math.Max(picked, notPicked);
    }
}
