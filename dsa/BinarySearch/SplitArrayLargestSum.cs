namespace BinarySearch;

public class SplitArrayLargestSum
{

    // Given an integer array nums and an integer k, split nums into k non-empty subarrays such that the largest sum of any subarray is minimized.
    // Return the minimized largest sum of the split.
    // A subarray is a contiguous part of the array.

    // Example 1:
    // Input: nums = [7,2,5,10,8], k = 2
    // Output: 18
    // Explanation: There are four ways to split nums into two subarrays.
    // The best way is to split it into [7,2,5] and [10,8], where the largest sum among the two subarrays is only 18.
    
    // Example 2:
    // Input: nums = [1,2,3,4,5], k = 2
    // Output: 9
    // Explanation: There are four ways to split nums into two subarrays.
    // The best way is to split it into [1,2,3] and [4,5], where the largest sum among the two subarrays is only 9.



    public static void Solution(int[] nums, int k)
    {
        System.Console.WriteLine(SplitArray(nums, k));
    }
    
    public static int SplitArray(int[] nums, int k) {
        int min = 0;
        int max = 0;
        int ans = -1;
        foreach(var num in nums)
        {
            min = Math.Max(min, num);
            max += num;
        }

        while(min <= max)
        {
            int mid = min + (max - min) / 2;
            var subArrayCount = GetSubarrayCount(nums, mid);

            if (subArrayCount <= k)
            {
                ans = mid;
                max = mid - 1;
            }
            else min = mid + 1;
        }
        return ans;
        
    }

    private static int GetSubarrayCount(int[] nums, int sum)
    {
        int total = 0;
        int partitions = 1;

        for (int i = 0; i < nums.Length; i++)
        {
            if (total + nums[i] > sum)
            {
                partitions++;
                total = nums[i];
            }
            else total += nums[i];
        }
        return partitions;
    }

}
