
using System.Text;

namespace String;

public class PalindromeCheck
{

    // Input: "abcba"
    // Output: true

    public static void Solution(string input)
    {
        // System.Console.WriteLine(NaiveSolution(input));
        System.Console.WriteLine(OptimalSolution(input));
    }


    // Time: O(n)
    // Space: O(n)
    private static bool NaiveSolution(string input)
    {
        var rev= new StringBuilder();
        for (int i = input.Length - 1; i>= 0; i--)
        {
            rev.Append(input[i]);
        }

        return string.Equals(rev.ToString(), input, StringComparison.OrdinalIgnoreCase);
    }

    private static bool OptimalSolution(string input)
    {
        int i = 0;
        int j = input.Length - 1;

        while (i <= j)
        {
            if (input[i] != input[j])
            {
                return false;
            }
            i++;
            j--;
        }
        return true;
    }
}
