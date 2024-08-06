
namespace DP;

public class SubsetSum
{

    // Given an array of non-negative integers, and a value sum, 
    // determine if there is a subset of the given set with sum equal to given sum. 


    // Example 1:
    // Input:
    // N = 6
    // arr[] = {3, 34, 4, 12, 5, 2}
    // sum = 9
    // Output: 1 
    // Explanation: Here there exists a subset with
    // sum = 9, 4+3+2 = 9.
    
    // Example 2:
    // Input:
    // N = 6
    // arr[] = {3, 34, 4, 12, 5, 2}
    // sum = 30
    // Output: 0 
    // Explanation: There is no subset with sum 30.

    public static void Solution(int[] arr, int sum)
    {
        Console.WriteLine(TopDownSolution(arr, sum, arr.Length));
    }

    private static bool TopDownSolution(int[] arr, int sum, int n)
    {
        var dp = new bool[n+1][];

        // initializing matrix
        for (int i = 0; i < dp.Length; i++)
        {
            dp[i] = new bool[sum + 1];
            Array.Fill(dp[i], false);
            dp[i][0] = true;
        }

        for (int i = 1; i < dp.Length; i++)
        {
            for (int j = 1 ; j < dp[0].Length; j++)
            {
                if (arr[i - 1] <= j)
                {
                    dp[i][j] = dp[i - 1][j - arr[i - 1]] || dp[i - 1][j];
                }
                else if (arr[i - 1] > j)
                {
                    dp[i][j] = dp[i - 1][j];
                }
            }
        }
        return dp[n][sum];
    }
}
