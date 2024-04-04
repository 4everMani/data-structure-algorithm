
namespace BinarySearch;

public class FindNthRootOfM
{
    //     Problem statement
    // You are given two positive integers 'n' and 'm'. You have to return the 'nth' root of 'm', i.e. 'm(1/n)'. If the 'nth root is not an integer, return -1.
    // Note:
    // 'nth' root of an integer 'm' is a number, which, when raised to the power 'n', gives 'm' as a result.

    // Example:
    // Input: ‘n’ = 3, ‘m’ = 27
    // Output: 3
    // Explanation: 
    // 3rd Root of 27 is 3, as (3)^3 equals 27.

    public static void Solution(int n, int m)
    {
        int res = FindNthRootOf(n, m);
        System.Console.WriteLine(res);
    }

    private static int FindNthRootOf(int n, int m)
    {
        int start  = 1;
        int end = m;

        while(start <= end)
        {
            int mid = start + (end - start) / 2;
            int value = CalculatePower(mid, n, m);
            if (value == 1)
            {
                return mid;
            }
            else if (value == 2)
            {
                end = mid - 1;
            }
            else start = mid + 1;
        }
        return -1;
    }

    private  static int CalculatePower(int num, int n, int m)
    {
        long ans = 1;
        for (int i = 1; i <= n; i++)
        {
            ans *= num;
            if (ans > m) return 2;
        }
        if (ans == m) return 1;
        return  0;

    }
}
