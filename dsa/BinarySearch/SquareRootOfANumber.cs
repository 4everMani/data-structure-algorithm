
namespace BinarySearch;

public class SquareRootOfANumber
{
    // Problem statement
    // You are given a positive integer ‘n’.
    // Your task is to find and return its square root. If ‘n’ is not a perfect square, then return the floor value of sqrt(n).

    // Example:
    // Input: ‘n’ = 7
    // Output: 2
    // Explanation:
    // The square root of the number 7 lies between 2 and 3, so the floor value is 2.

    public static void Solution(int n)
    {
        int result = FindSquareRoot(n);
        System.Console.WriteLine(result);
    }

    // we know that square root of a number "n" lies between 0 and n;
    // since we know the range of output and range is in increasing order.
    // then we can apply binary search here;

    private static int FindSquareRoot(int n)
    {
        if (n == 0) return 0;
        int start = 1;
        int end = n;
        int ans = -1;

        while(start <= end)
        {
            int mid = start + (end - start) / 2;
            if (mid * mid <= n)
            {
                ans = Math.Max(ans, mid);
                start = mid + 1;
            }
            else if (mid * mid > n)
            {
                end = mid - 1;
            }
        }
        return ans;
    }
}
