
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
}
