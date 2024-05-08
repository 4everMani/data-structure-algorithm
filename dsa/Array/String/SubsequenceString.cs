
namespace String;

public class SubsequenceString
{
    // Given two strings
    // Find out is second string is subsequence of first one?
    // Subsequence means: A subsequence of a string is a new string that is formed from the original string by 
    // deleting some (can be none) of the characters without disturbing the relative positions of the remaining characters.
    // "ABC" => {"", A, B, C, AB, AC, BC, ABC}

    public static void Solution(string s, string t)
    {
        System.Console.WriteLine(NaiveSoluiton(s, t));
    }

    // Time: O(len(t) * len(s))
    private static bool NaiveSoluiton(string s, string t)
    {
        int j = 0;

        for (int i = 0; i < t.Length; i++)
        {
            bool isFound = false;

            while (j < s.Length)
            {
                if (s[j] == t[i])
                {
                    isFound = true;
                    break;
                }
                j++;
            }
            if (!isFound) return false;
            j++;
        }
        return true;
    }

    // Time: O(len(s))
    private static bool BetterSolution(string s, string t)
    {
        if (t.Length > s.Length) return false;

        int j = 0;
        for (int i = 0; i < s.Length && j < t.Length; i++)
        {
            if (s[i] == t[j]) j++;
        }
        return j == t.Length;
    }
}
