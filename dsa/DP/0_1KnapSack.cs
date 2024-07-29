
namespace DP;

public class _0_1KnapSack
{


    // You are given weights and values of N items, 
    // put these items in a knapsack of capacity W to get the maximum total value in the knapsack. 
    // Note that we have only one quantity of each item.
    // In other words, given two integer arrays val[0..N-1] and wt[0..N-1] which represent values and 
    // weights associated with N items respectively. 
    // Also given an integer W which represents knapsack capacity, 
    // find out the maximum value subset of val[] such that 
    // sum of the weights of this subset is smaller than or equal to W. 
    // You cannot break an item, either pick the complete item or dont pick it (0-1 property).

    // Example 1:
    // Input:
    // N = 3
    // W = 4
    // values[] = {1,2,3}
    // weight[] = {4,5,1}
    // Output: 3
    // Explanation: Choose the last item that weighs 1 unit and holds a value of 3. 
    
    // Example 2:
    // Input:
    // N = 3
    // W = 3
    // values[] = {1,2,3}
    // weight[] = {4,5,6}
    // Output: 0
    // Explanation: Every item has a weight exceeding the knapsack's capacity (3).


    public static void Solution(int[] weight, int[] values, int capacity, int n)
    {
        Console.WriteLine(RecursiveSolution(weight, values, capacity, n));
        Console.WriteLine(TopDownSolution(weight, values, n, capacity));
    }

    private static int RecursiveSolution(int[] weight, int[] values, int capacity, int n)
    {
        if (n == 0 || capacity == 0) return 0;

        else if (weight[n - 1] <= capacity)
        {
            // pick
            var pickedValues = values[n - 1] + RecursiveSolution(weight, values, capacity - weight[n - 1], n - 1);

            // not picked
            var notPickedValues = RecursiveSolution(weight, values, capacity, n - 1);

            return Math.Max(pickedValues, notPickedValues);
        }
        else if (weight[n - 1] > capacity)
        {
            // not picked
            return RecursiveSolution(weight, values, capacity, n - 1);
        }
        return 0;
    }

#region memozed solution
    private static int MemoizedSolution(int[] weight, int[] values, int capacity, int n)
    {
        var dp = new int[n + 1][];
        
        for (int i = 0; i < n + 1; i++)
        {
            dp[i] = new int[capacity + 1];
            Array.Fill(dp[i], -1);
        }
        return FindMaxProfit(weight, values, capacity, n, dp);
    }

    private static int FindMaxProfit(int[] weight, int[] values, int capacity, int n, int[][] output)
    {
        if (n == 0 || capacity == 0) return 0;

        else if (output[n][capacity] != -1) return output[n][capacity];

        else if (capacity >= weight[n - 1])
        {
            return output[n][capacity] = Math.Max(
                values[n-1] + FindMaxProfit(weight, values, capacity - weight[n - 1], n - 1, output), 
                FindMaxProfit(weight, values, capacity, n - 1, output));
        }
        else if (capacity < weight[n - 1])
        {
            return output[n][capacity] = FindMaxProfit(weight, values, capacity, n - 1, output);
        }
        return 0;
    }

#endregion

#region  Top-Down Approach

    public static int TopDownSolution(int[] wt, int[]vt, int n, int w)
    {
        var dp = new int[n + 1][];
        for (int i = 0; i < dp.Length; i++)
        {
            dp[i] = new int[w + 1];
        }

        // Initializing dp
        Array.Fill(dp[0], 0);
        
        for (int i = 0; i < dp.Length; i++)
        {
            dp[i][0] = 0;
        }

        for (int i = 1; i < dp.Length; i++)
        {
            for (int j = 1; j < dp[0].Length; j++)
            {
                if (wt[i - 1] <= j)
                {
                    dp[i][j] = Math.Max(vt[i - 1] + dp[i - 1][j - wt[i - 1]], dp[i - 1][j]);
                }
                else if(wt[i - 1] > j)
                {
                    dp[i][j] = dp[i - 1][j];
                }
            }
        }
        return dp[n][w];
    }
#endregion


}
