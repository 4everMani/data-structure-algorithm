
using System.Text;

namespace String;

public class LargestOddNumberInString
{

    // You are given a string num, representing a large integer. Return the largest-valued odd integer (as a string) that is a non-empty substring of num, or an empty string "" if no odd integer exists.

    // A substring is a contiguous sequence of characters within a string.

    // Example 1:
    // Input: num = "52"
    // Output: "5"
    // Explanation: The only non-empty substrings are "5", "2", and "52". "5" is the only odd number.
    
    // Example 2:
    // Input: num = "4206"
    // Output: ""
    // Explanation: There are no odd numbers in "4206".
    
    // Example 3:
    // Input: num = "35427"
    // Output: "35427"
    // Explanation: "35427" is already an odd number.

    public static void Solution(string num)
    {
        System.Console.WriteLine(OptimalSolution(num));
    }


    private static string BetterSolution(string num)
    {
        var str = new StringBuilder(num);

        while (str.Length > 0)
        {
            int value = (int)str[str.Length - 1];
            if (value % 2 == 0) return str.ToString();
            else 
            {
                str.Remove(str.Length - 1,1);
            }
        }
        return "";
    }


    private static string OptimalSolution(string num)
    {
        var i = num.Length - 1;

        while (i >= 0)
        {
            if ((int)num[i] % 2 != 0) return num[0..(i+1)];
            i--;
        }
        return "";
    }
}
