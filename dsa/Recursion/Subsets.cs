

namespace Recursion;

public class Subsets
{
    // Given an integer array nums of unique elements, return all possible 
    // subsets(the power set).

    // The solution set must not contain duplicate subsets. Return the solution in any order.

    // Example 1:

    // Input: nums = [1,2,3]
    // Output: [[],[1],[2],[1,2],[3],[1,3],[2,3],[1,2,3]]
    // Example 2:

    // Input: nums = [0]
    // Output: [[],[0]]

    public static void Solution(int[] nums)
    {
        IList<IList<int>> output = FindSubsets(nums);
        var str = output.Select(x => string.Join(',', x));
        System.Console.WriteLine(string.Join('|', str));
    }

    private static IList<IList<int>> FindSubsets(int[] nums)
    {
        IList<IList<int>> output = [];
        List<int> currentArr = [];
        Helper(nums, 0, currentArr, output);
        return output;
    }

    private static void Helper(int[] nums, int ind, List<int> currArr, IList<IList<int>> output)
    {

       
        if (ind >= nums.Length) 
        {
            List<int> temp = [];
            temp.AddRange(currArr);
            output.Add(temp);
            return;
        }
        // pick
        currArr.Add(nums[ind]);
        Helper(nums, ind + 1, currArr, output);

        currArr.RemoveAt(currArr.Count - 1);
        // not pick
        Helper(nums, ind + 1, currArr, output);
    }
}

