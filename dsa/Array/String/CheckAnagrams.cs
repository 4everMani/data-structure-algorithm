
namespace String;

public class CheckAnagrams
{
    // Given two strings s and t, return true if t is an anagram of s, and false otherwise.

    // An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, 
    //typically using all the original letters exactly once.

    // Example 1:
    // Input: s = "anagram", t = "nagaram"
    // Output: true

    // Example 2:
    // Input: s = "rat", t = "car"
    // Output: false

    public static void Solution(string s, string t)
    {
        System.Console.WriteLine(NaiveSolution(s, t));
    }


    // Time: O(nlog(s.Length)) + O(nlog(t.Length)) + O(len(s))
    private static bool NaiveSolution(string s, string t)
    {
        if (t.Length > s.Length) return false;
        var s1 = new string(s.OrderBy(s => s).ToArray());
        var s2 = new string(t.OrderBy(s => s).ToArray());

        return s1.Equals(s2);
    }

    // Time: O(len(s))
    // Space: O(len(s))
    private static bool BetterSolution(string s, string t)
    {
        if (t.Length != s.Length) return false;
        var dict = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (dict.ContainsKey(s[i])) 
            {
                dict[s[i]] += 1;
            }
            else dict.Add(s[i], 1);
        }

        for (int j = 0; j < t.Length; j++)
        {
            if (!dict.ContainsKey(t[j])) return false;
            else if (dict[t[j]] == 0) return false;
            dict[t[j]] -= 1;
        }
        return true;
    }
}
