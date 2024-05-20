
using System.Text;

namespace String;

public class RotatedString
{
    // Given two strings s and goal, return true if and only if s can become goal after some number of shifts on s.

    // A shift on s consists of moving the leftmost character of s to the rightmost position.

    // For example, if s = "abcde", then it will be "bcdea" after one shift.
    

    // Example 1:
    // Input: s = "abcde", goal = "cdeab"
    // Output: true
    
    // Example 2:
    // Input: s = "abcde", goal = "abced"
    // Output: false

    public static void Solution(string s, string goal)
    {
        System.Console.WriteLine(OptimalSolution(s, goal));
    }

    private static bool BetterSolution(string s, string goal)
    {
        return s.Length == goal.Length && (s + s).Contains(goal);
    }

    // Time: O(n)
    // Space: O(n)
    private static bool OptimalSolution(string s, string goal)
    {
        if (s.Length != goal.Length) return false;
        if (string.Equals(goal, s)) return true;
        var str = new StringBuilder();
        str.Append(s);
        for (int i = 0; i < s.Length - 1; i++)
        {
            var v = str[0];
            str.Remove(0, 1);
            str.Append(v);
            if (str.Equals(goal)) return true;
        }
        return false;
    }
}
