

namespace Backtracking;

public class Permutation
{
    // Given an array nums of distinct integers, return all the possible permutations. You can return the answer in any order.

    // Example 1:
    // Input: nums = [1,2,3]
    // Output: [[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]
    
    // Example 2:
    // Input: nums = [0,1]
    // Output: [[0,1],[1,0]]
    
    // Example 3:
    // Input: nums = [1]
    // Output: [[1]]

    public static void Solution(int[] nums)
    {
        var output = FindPermutation(nums);

        foreach(var i in output)    
        {
            System.Console.WriteLine(string.Join(" ", i));
        }
    }

    private static IList<IList<int>> FindPermutation(int[] nums)
    {
        IList<IList<int>> output = [];
        IList<int> current = [];
        HashSet<int> used = [];
        // Helper(nums, current, output, used);
        HelperII(nums, output, used);
        return output;
    }

    private static void Helper(int[] nums, IList<int> current, IList<IList<int>> output, HashSet<int> used)
    {
        if (current.Count == nums.Length)
        {
            output.Add(new List<int>(current));
            return;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (!used.Contains(nums[i]))
            {
                current.Add(nums[i]);
                used.Add(nums[i]);
                Helper(nums, current, output, used);
                current.RemoveAt(current.Count - 1);
                used.Remove(nums[i]);
            }
        }
    }

    private static void HelperII(int[] nums, IList<IList<int>> output, HashSet<int> used)
    {
        if (used.Count == nums.Length)
        {
            output.Add(new List<int>(used.ToList()));
            return;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (!used.Contains(nums[i]))
            {
                used.Add(nums[i]);
                HelperII(nums, output, used);
                used.Remove(nums[i]);
            }
        }
    }
}
