
namespace String;

public class MaximumNestingDepthOfTheParentheses
{
    // Given a valid parentheses string s, return the nesting depth of s. 
    // The nesting depth is the maximum number of nested parentheses.

    // Example 1:
    // Input: s = "(1+(2*3)+((8)/4))+1"
    // Output: 3
    // Explanation:
    // Digit 8 is inside of 3 nested parentheses in the string.

    // Example 2:
    // Input: s = "(1)+((2))+(((3)))"
    // Output: 3
    // Explanation:
    // Digit 3 is inside of 3 nested parentheses in the string.

    // Example 3:
    // Input: s = "()(())((()()))"
    // Output: 3

    public static void Solution(string s)
    {
        System.Console.WriteLine(OptimalSolution(s));
    }

    private static int OptimalSolution(string s)
    {
        int maxCount = 0;
        int count = 0;

        foreach(char c in s)
        {
            if (c == '(')
            {
                count++;
                maxCount = Math.Max(count, maxCount);
            }
            else if (c == ')') count--;
        }
        return maxCount;
    }
}
