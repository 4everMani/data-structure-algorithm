
namespace String;

public class FirstUniqueCharacter
{
    // Given a string s, find the first non-repeating character in it and return its index. If it does not exist, return -1.

    // Example 1:
    // Input: s = "leetcode"
    // Output: 0

    // Example 2:
    // Input: s = "loveleetcode"
    // Output: 2

    // Example 3:
    // Input: s = "aabb"
    // Output: -1

    public static void Solution(string s)
    {
        System.Console.WriteLine(NaiveSolution(s));
        System.Console.WriteLine(BetterSolution(s));
    }

    // Time: O(n^2)
    private static int NaiveSolution(string s)
    {
        for (int i = 0; i < s.Length; i++)
        {
            if (IsCharExists(s, s[i], i)) return i;
        }
        return -1;
    }

    private static int BetterSolution(string s)
    {
        var dict = new Dictionary<char, int>();
        foreach (char c in s)
        {
            if (!dict.ContainsKey(c)) dict.Add(c, 1);
            else dict[c]+= 1;
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (dict[s[i]] == 1) return i;
        }
        return -1;
    }

    private static bool IsCharExists(string s, char target, int index)
    {
        for (int i = 0; i < s.Length; i++)
        {
            if (i == index) continue;
            if (s[i] == target) return false;
        }
        return true;
    }
}
