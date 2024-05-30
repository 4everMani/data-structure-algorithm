namespace Recursion;

public class MinCostClimbingStairs
{
    public static void Solution(int[] cost)
    {
        System.Console.WriteLine(MinCost(cost));
    }
    public static int MinCost(int[] cost) {
        return Cost(cost, cost.Length);
    }

    public static int Cost(int[] cost, int n)
    {
        if (n <= 1) return cost[n];
        int val = (n == cost.Length ? 0 : cost[n]) + Math.Min(Cost(cost, n - 1), Cost(cost, n - 2));
       return val;
    }
}






