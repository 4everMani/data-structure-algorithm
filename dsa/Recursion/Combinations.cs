

namespace Recursion;

public class Combinations
{
    // Given two integers n and k, return all possible combinations of k numbers chosen from the range [1, n].
    // You may return the answer in any order.

    // Example 1:
    // Input: n = 4, k = 2
    // Output: [[1,2],[1,3],[1,4],[2,3],[2,4],[3,4]]
    // Explanation: There are 4 choose 2 = 6 total combinations.
    // Note that combinations are unordered, i.e., [1,2] and [2,1] are considered to be the same combination.
    
    // Example 2:
    // Input: n = 1, k = 1
    // Output: [[1]]
    // Explanation: There is 1 choose 1 = 1 total combination.

    public static void Solution(int nums, int k)
    {
        FindCombinaitons(nums, k);
    }

    private static IList<IList<int>> FindCombinaitons(int nums, int k)
    {
        IList<IList<int>> output = [];
        int[] arr = new int[nums];
        for (int i = 0; i < nums; i++)
        {
            arr[i] = i + 1;
        }
        // Helper(arr, k, output, new List<int>(), 0);
        // HelperII(nums, k, output, new List<int>(), 1);
        Helper3(nums, k , output, new List<int>(), 1);
        return output;
    }

    private static void Helper(int[] arr, int k, IList<IList<int>> output, List<int> current, int ind)
    {
        if (current.Count == k)
        {
            output.Add(new List<int>(current));
            return;
        }
        else if (ind == arr.Length) return;

        current.Add(arr[ind]);
        Helper(arr, k, output, current, ind + 1);
        current.RemoveAt(current.Count - 1);
        Helper(arr, k, output, current, ind + 1);
    }

    private static void HelperII(int n, int k, IList<IList<int>> output, List<int> current, int ind)
    {
        if (k == 0)
        {
            output.Add(new List<int>(current));
            return;
        }
        else if (ind > n) return;

        current.Add(ind);
        HelperII(n, k - 1, output, current, ind + 1);
        current.RemoveAt(current.Count - 1);
        HelperII(n, k, output, current, ind + 1);
    }

    private static void Helper3(int n, int k, IList<IList<int>> output, List<int> current, int ind)
    {
        if (k == current.Count)
        {
            output.Add(new List<int>(current));
            return;
        }
        for (int i = ind; i <= n; i++)
        {
            current.Add(i);
            Helper3(n, k , output, current, i + 1);
            current.RemoveAt(current.Count - 1);
        }
    }

    public IList<IList<int>> Combine(int n, int k) {
        var result = new List<IList<int>>();
        Backtrack(1, new List<int>(), n, k, result);
        return result;
    }

    private void Backtrack(int start, List<int> currentCombination, int n, int k, List<IList<int>> result) {
        if (currentCombination.Count == k) {
            result.Add(new List<int>(currentCombination));
            return;
        }

        for (int i = start; i <= n; i++) {
            currentCombination.Add(i);
            Backtrack(i + 1, currentCombination, n, k, result);
            currentCombination.RemoveAt(currentCombination.Count - 1);
        }
    }
}
