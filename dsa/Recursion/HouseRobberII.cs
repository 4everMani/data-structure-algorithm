namespace Recursion;

public class HouseRobberII
{
    // You are a professional robber planning to rob houses along a street. 
    // Each house has a certain amount of money stashed. All houses at this place are arranged in a circle. 
    // That means the first house is the neighbor of the last one. Meanwhile, 
    // adjacent houses have a security system connected, and it will automatically contact the police 
    // if two adjacent houses were broken into on the same night.

    // Given an integer array nums representing the amount of money of each house, 
    //return the maximum amount of money you can rob tonight without alerting the police.

    

    // Example 1:

    // Input: nums = [2,3,2]
    // Output: 3
    // Explanation: You cannot rob house 1 (money = 2) and then rob house 3 (money = 2), because they are adjacent houses.
    // Example 2:

    // Input: nums = [1,2,3,1]
    // Output: 4
    // Explanation: Rob house 1 (money = 1) and then rob house 3 (money = 3).
    // Total amount you can rob = 1 + 3 = 4.
    // Example 3:

    // Input: nums = [1,2,3]
    // Output: 3

    public static void Solution(int[] nums)
    {
        // var set = new HashSet<int>();
        // int result = FindMax(houses, 0, set);
        var output = 0;
        if (nums.Length == 1) 
        {
            output = nums[0];
            return;
        }
        output =  Math.Max(FindMaxII(nums, 0, nums.Length - 1), FindMaxII(nums, 1, nums.Length));
        System.Console.WriteLine(output);
    }
    private static int FindMax(int[] nums, int ind, HashSet<int> set)
    {
        if (ind >= nums.Length) return 0;
        if (ind == nums.Length - 1 && set.Contains(0)) return 0;

        // include
        set.Add(ind);
        var picked = nums[ind] + FindMax(nums, ind + 2, set);

        // not include 
        set.Remove(ind);
        var notPicked = FindMax(nums, ind + 1, set);

        return Math.Max(picked, notPicked);
    }

    private static int FindMaxII(int[] nums, int ind, int n)
    {
        if (ind >= n) return 0;

        // include
        var picked = nums[ind] + FindMaxII(nums, ind + 2, n);

        // not include
        var notPicked = FindMaxII(nums, ind + 1, n);

        return Math.Max(picked, notPicked);
    }
}
