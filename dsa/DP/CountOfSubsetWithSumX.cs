
namespace DP;

public class CountOfSubsetWithSumX
{
    // Given an array arr[] of length N and an integer X, the task is to find the number of subsets with a sum equal to X.

    // Examples: 

    // Input: arr[] = {1, 2, 3, 3}, X = 6 
    // Output: 3 
    // All the possible subsets are {1, 2, 3}, 
    // {1, 2, 3} and {3, 3}

    // Input: arr[] = {1, 1, 1, 1}, X = 1 
    // Output: 4 

    public static void Solution(int[] arr, int sum)
    {
        Console.WriteLine(MatrixSolution(arr, sum, arr.Length));
    }

    public static int MatrixSolution(int[] arr, int sum, int n)
    {
        var dp = new int[n + 1][];

        // initializing 2-D Array
        for (int i = 0; i < dp.Length; i++)
        {
            dp[i] = new int[sum + 1];
            Array.Fill(dp[i], 0);
            dp[i][0] = 1;
        }

        for (int i = 1; i < dp.Length; i++)
        {
            for (int j = 1; j < dp[i].Length; j++)
            {
                if (arr[i - 1] <= j)
                {
                    dp[i][j] = dp[i - 1][j - arr[i - 1]] + dp[i - 1][j];
                }
                else dp[i][j] = dp[i - 1][j];
            }
        }
        return dp[n][sum];
    }
}
