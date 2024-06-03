using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Recursion;

public class GenerateParentheses
{
    // Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.

    // Example 1:
    // Input: n = 3
    // Output: ["((()))","(()())","(())()","()(())","()()()"]
    
    // Example 2:
    // Input: n = 1
    // Output: ["()"]

    public static void Solution(int n)
    {
        IList<string> output = [];
        var str = new StringBuilder();
        // Helper(n, output, "", 0, 0);
        HelperII(n, output, str, 0, 0);
        foreach (var item in output) str.Append(item + ',');
        System.Console.WriteLine(str.ToString());


    }

    private static void Helper(int n, IList<string> output, string str, int open, int close)
    {
        if ((open + close) == 2 * n)
        {
            // var strOut = new StringBuilder(str.ToString());
            output.Add(str);
            // str.Remove(str.Length - 1, 1);
            // str.Remove(str.Length - 1, 1);
            return;
        }

        // picking open
        if (open < n)
        {
            // str.Append('(');
            Helper(n, output, str + '(', open + 1, close);
        }

        // picking close
        if (close < open)
        {
            // str.Append(')');
            Helper(n, output, str + ')', open, close + 1);
        }
    }

     private static void HelperII(int n, IList<string> output, StringBuilder str, int open, int close)
    {
        if ((open + close) == 2 * n)
        {
            // var strOut = new StringBuilder(str.ToString());
            output.Add(str.ToString());
            return;
        }

        // picking open
        if (open < n)
        {
            str.Append('(');
            HelperII(n, output, str, open + 1, close);
            str.Remove(str.Length - 1, 1);
        }

        // picking close
        if (close < open)
        {
            str.Append(')');
            HelperII(n, output, str, open, close + 1);
            str.Remove(str.Length - 1, 1);
        }
    }
}

