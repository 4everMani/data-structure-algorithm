
namespace DP;

public class PartitionsWithGivenDifference
{
    // Given an array arr, partition it into two subsets(possibly empty) such that 
    // each element must belong to only one subset. Let the sum of the elements of these two subsets be S1 and S2. 
    // Given a difference d, count the number of partitions in which S1 is greater than or equal to S2 and the difference between S1 and S2 is equal to d. 
    // Since the answer may be large return it modulo 109 + 7.

    // Input:
    // n = 4
    // d = 0 
    // arr[] = {1, 1, 1, 1} 
    // Output: 6 
    // Explanation:
    // we can choose two 1's from indices {0,1}, {0,2}, {0,3}, {1,2}, {1,3}, {2,3} and put them in S1 and remaning two 1's in S2.
    // Thus there are total 6 ways for partition the array arr. 

    public static void Solution(int[] arr, int n, int d)
    {
        Console.WriteLine(OptimalSolution(arr, n, d));
    }

    private static int OptimalSolution(int[] arr, int n, int d)
    {
        var totalSum = 0;
        for (int i = 0; i < arr.Length ; i++)
        {
            totalSum += arr[i];
        }
        var targetSum = (totalSum + d) / 2;
        // return CountNumberOfSubsetWithGivenSum(arr, targetSum);
        return CountOfSubsetWithSumX.MatrixSolution(arr, targetSum, arr.Length);
    }

    private static int CountNumberOfSubsetWithGivenSum(int[] arr, int sum)
    {
        var dp = new int[arr.Length + 1][];
        for (int i = 0; i < dp.Length; i++)
        {
            dp[i] = new int[sum + 1];
            dp[i][0] = 1;
        }

        for (int i = 1; i < dp.Length; i++)
        {
            for (int j = 1; j < dp[0].Length; j++)
            {
                if ( arr[i - 1] <= j)
                {
                    dp[i][j] = (dp[i - 1][j - arr[i - 1]] + dp[i - 1][j]) % 1000000007;
                }
                else dp[i][j] = (dp[i - 1][j]) % 1000000007;
            }
        }
        return dp[arr.Length][sum];
    }
}
