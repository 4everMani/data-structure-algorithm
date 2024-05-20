
namespace String;

public class IsomorphicString
{
    // Given two strings s and t, determine if they are isomorphic.
    // Two strings s and t are isomorphic if the characters in s can be replaced to get t.
    // All occurrences of a character must be replaced with another character while preserving the order of characters. 
    // No two characters may map to the same character, but a character may map to itself.

    // Example 1:
    // Input: s = "egg", t = "add"
    // Output: true
    
    // Example 2:
    // Input: s = "foo", t = "bar"
    // Output: false
    
    // Example 3:
    // Input: s = "paper", t = "title"
    // Output: true

    public static void Solution(string s, string t)
    {
        System.Console.WriteLine(NaiveSolution(s, t));
    }

    private static bool NaiveSolution(string s, string t)
    {
        var dict = new Dictionary<char, char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (!dict.ContainsKey(s[i]))
            {  
                // checking if t[i] is already mapped
                if (dict.ContainsValue(t[i])) return false;
                dict.Add(s[i], t[i]);
            }
            else
            {
                var value = dict[s[i]];
                if (value != t[i]) return false;
            }
        }
        return true;
    }
}
