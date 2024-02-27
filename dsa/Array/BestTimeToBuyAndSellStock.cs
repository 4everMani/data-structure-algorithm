using System;

namespace Array;

public class BestTimeToBuyAndSellStock
{

    // You are given an array prices where prices[i] is the price of a given stock on the ith day.
    // You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

    // Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.

    

    // Example 1:

    // Input: prices = [7,1,5,3,6,4]
    // Output: 5
    // Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
    // Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
    // Example 2:

    // Input: prices = [7,6,4,3,1]
    // Output: 0
    // Explanation: In this case, no transactions are done and the max profit = 0.



    public static void Solution(int[] prices)
    {
        // int result = NaiveSolution(prices);
        int result = OptimalSolution(prices);
        Console.WriteLine(result);
    }

    private static int NaiveSolution(int[] prices)
    {
        var left = 0;
        var right = 0;
        var diff = 0;

        for (int i = 0; i < prices.Length; i++)
        {
            for (int j = i + 1; j < prices.Length; j++)
            {
                if (diff < (prices[j] - prices[i]))
                {
                    diff = prices[j] - prices[i];
                    left = i;
                    right = j;
                }
            }
        }
        return diff > 0 ? prices[right] - prices[left] : 0;
    }

    private static int OptimalSolution(int[] prices)
    {
        int maxSum = 0;
        int inititalIndex = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[inititalIndex] > prices[i])
            {
                inititalIndex = i;
            }
            else
            {
                var profit = prices[i] - prices[inititalIndex];
                maxSum = Math.Max(profit, maxSum);
            }
        }
        return maxSum;
    }
}
