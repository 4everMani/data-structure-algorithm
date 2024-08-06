
namespace DP;

public class MinimumSumPartition
{
        // Given an array arr of size n containing non-negative integers, 
        // the task is to divide it into two sets S1 and S2 such that 
        // the absolute difference between their sums is minimum and find the minimum difference


        // Example 1:
        // Input: N = 4, arr[] = {1, 6, 11, 5} 
        // Output: 1
        // Explanation: 
        // Subset1 = {1, 5, 6}, sum of Subset1 = 12 
        // Subset2 = {11}, sum of Subset2 = 11   
        
        // Example 2:
        // Input: N = 2, arr[] = {1, 4}
        // Output: 3
        // Explanation: 
        // Subset1 = {1}, sum of Subset1 = 1
        // Subset2 = {4}, sum of Subset2 = 4

        public static void Solution(int[] arr)
        {
            Console.WriteLine(OptimizedSolution(arr));
        }

    private static int OptimizedSolution(int[] arr)
    {
        // getting the range
        int range = arr.Sum(x => x);    

        // starting subset sum implementation
        var dp = new bool[arr.Length + 1][];

        for (int i =0; i < dp.Length; i++)
        {
            dp[i] = new bool[range + 1];
            dp[i][0] = true;
        }

        for (int i = 1; i < dp.Length; i++)
        {
            for (int j = 1; j< dp[i].Length; j++)
            {
                if (arr[i - 1] <= j)
                {
                    dp[i][j] = dp[i - 1][j - arr[i - 1]] || dp[i - 1][j];
                }
                else dp[i][j] = dp[i - 1][j];
            }
        }

        // Filtering the elements that are sum of subset
        var list = new List<int>();
        for (int k = 0; k < dp[0].Length / 2; k++)
        {
            if (dp[dp.Length - 1][k] == true)
            {
                list.Add(k);
            }
        }

        int minDiff = int.MaxValue;

        for (int m = 0; m < list.Count; m++)
        {
            minDiff = Math.Min(minDiff, range - (2* list[m]));
        }
        return minDiff;

    }
}
