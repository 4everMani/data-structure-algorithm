using System;

namespace Array;

public class MajorityElement
{

    // Given an array nums of size n, return the majority element.

    // The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.

    // Example 1:
    // Input: nums = [3,2,3]
    // Output: 3

    // Example 2:
    // Input: nums = [2,2,1,1,1,2,2]
    // Output: 2



    public static void Solution(int[] nums)
    {
        System.Console.WriteLine(OptimalSolution(nums));
    }

    // Naive solution will be two nested for loop with Time: O(n^2)

    // Better1 solution will be store element and their count in dictionary with Time: O(n) and Space: O(n)

    // Time: O(nlogn) + O(n)
    private static int BetterSolutionII(int[] nums)
    {
        var maxCount = 0;
        var count = 0;
        var startIndex = 0;
        var maxElement = 0;
        // Array.Sort(nums);
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[startIndex] == nums[i])
            {
                count++;
            }
            else
            {
                if (maxCount < count)
                {
                    maxCount = count;
                    maxElement = nums[startIndex];
                }
                startIndex = i;
                count = 1;
            }
        }
        return (maxCount > count) ? maxElement : nums[startIndex];
    }

    public static int OptimalSolution(int[] nums) {
        var element = 0;
        var count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (count == 0)
            {
                element = nums[i];
                count++;
            }
            else if (nums[i] == element) count++;
            else count--;
        }
        return element;
    }
}
