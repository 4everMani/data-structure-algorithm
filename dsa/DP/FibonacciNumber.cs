

namespace DP;

public class FibonacciNumber
{
    public static void Solution(int n)
    {
        System.Console.WriteLine(FindFibonacci(n));
    }

    private static int FindFibonacci(int n)
    {
        if (n <= 1) return n;
        int[] arr = new int[n + 1];
        for (int i = 0; i <= n; i++)
        {
            arr[i] = -1;
        }
        Helper(n, arr);
        return arr[n];
    }

    private static int Helper(int n, int[] arr)
    {
        if (n <= 1) return n;
        if (arr[n] != -1)
        {
            return arr[n];
        }
        else 
        {
            arr[n] = Helper(n - 1, arr) + Helper(n - 2, arr);
            return arr[n];
        }
    }
}



