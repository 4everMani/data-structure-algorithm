
namespace DP;

public class EqualSumPartition
{
    // The partition problem is to determine whether a given set can be partitioned into two subsets 
    // such that the sum of elements in both subsets is the same. 

    // Examples: 
    // Input: arr[] = {1, 5, 11, 5}
    // Output: true 
    // The array can be partitioned as {1, 5, 5} and {11}

    // Input: arr[] = {1, 5, 3}
    // Output: false 
    // The array cannot be partitioned into equal sum sets.

    public static void Solution(int[] arr)
    {
        Console.WriteLine(TopDownSolution(arr));
    }

    private static bool TopDownSolution(int[] arr)
    {
        var sum = arr.Sum(x => x);

        if (sum % 2 != 0) return false;
        else
        {
            var n = arr.Length;
            var subsetSum = sum / 2;
            var dp = new bool[n+1][];

            // initializing matrix
            for (int i = 0; i < dp.Length; i++)
            {
                dp[i] = new bool[subsetSum + 1];
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
            return dp[n][subsetSum];
        }
    }
}
