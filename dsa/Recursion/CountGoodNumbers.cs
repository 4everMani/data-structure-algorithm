namespace Recursion;

public class CountGoodNumbers
{
    // A digit string is good if the digits (0-indexed) at even indices are even and the digits at odd indices are prime (2, 3, 5, or 7).

    // For example, "2582" is good because the digits (2 and 8) at even positions are even and the digits (5 and 2) at odd positions are prime. 
    // However, "3245" is not good because 3 is at an even index but is not even.
    // Given an integer n, return the total number of good digit strings of length n. Since the answer may be large, return it modulo 109 + 7.

    // A digit string is a string consisting of digits 0 through 9 that may contain leading zeros.

    

    // Example 1:

    // Input: n = 1
    // Output: 5
    // Explanation: The good numbers of length 1 are "0", "2", "4", "6", "8".
    // Example 2:

    // Input: n = 4
    // Output: 400
    // Example 3:

    // Input: n = 50
    // Output: 564908303

    public static void Solution(long n)
    {
        Console.WriteLine(Count(n));
    }

    public static int Count(long n) {
        int mod = 1000000007;
        long evenCount = (n+1)/2;
        long oddCount = (n/2);

        long oddTotal = Helper(4, oddCount, mod);
        long evenTotal = Helper(5, evenCount, mod);
        var output = (evenTotal * oddTotal) % mod;
        return (int)output;
    }

    private static long Helper(long baseVal, long exp, int mod) {
        if (exp == 0) {
            return 1;
        }
        
        long half = Helper(baseVal, exp / 2, mod);
        long halfMod = (half * half) % mod;
        
        if (exp % 2 == 0) {
            return halfMod;
        } else {
            return (halfMod * baseVal) % mod;
        }
    }
}
