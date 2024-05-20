
namespace String;

public class SumOfBeautyOfAllSubstrings
{
    // The beauty of a string is the difference in frequencies between the most frequent and least frequent characters.

    // For example, the beauty of "abaacc" is 3 - 1 = 2.
    // Given a string s, return the sum of beauty of all of its substrings.

    // Example 1:
    // Input: s = "aabcb"
    // Output: 5
    // Explanation: The substrings with non-zero beauty are ["aab","aabc","aabcb","abcb","bcb"], each with beauty equal to 1.
    
    // Example 2:
    // Input: s = "aabcbaa"
    // Output: 17

    public static void Solution(string s)
    {
        System.Console.WriteLine(OptimalSolution(s));
    }

    // Time: O(n^2) * O(26) // A dictionary may have maximum of 26 letters
    // Space: O(26)
    private static int OptimalSolution(string s)
    {
        var sum = 0;

        for (int i = 0; i < s.Length; i++)
        {
            var dict = new Dictionary<char, int>();
            for (int j = i; j < s.Length; j++)
            {
                if (dict.ContainsKey(s[j]))
                {
                    dict[s[j]]++;
                   
                }
                else 
                {
                  dict.Add(s[j], 1);
                  
                }
                if (dict.Count > 1)
                {
                    
                    sum += CountDifferenceOfFreq(dict);
                }
            }
        }
        return sum;
    }

    private static int CountDifferenceOfFreq(Dictionary<char,int> dict)
    {
        var min = int.MaxValue;
        var max = int.MinValue;

        foreach (var kvp in dict)
        {
            min = Math.Min(min, kvp.Value);
            max = Math.Max(max, kvp.Value);
        }
        return max-min;
    }
}
