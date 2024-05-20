
using System.Text;

namespace String;

public class CountNumberOfSubstring
{
    // Given a string of lowercase alphabets, count all possible substrings (not necessarily distinct) that have exactly k distinct characters. 

    // Example 1:
    // Input:
    // S = "aba", K = 2
    // Output:
    // 3
    // Explanation:
    // The substrings are: "ab", "ba" and "aba".
    
    // Example 2:
    // Input: 
    // S = "abaaca", K = 1
    // Output:
    // 7
    // Explanation:
    // The substrings are: "a", "b", "a", "aa", "a", "c", "a". 

    public static void Solution(string s, int k)
    {
        System.Console.WriteLine(OptimalSolution(s, k));
    }

    // Time: O(n^3)
    // Space: O(n)
    private static int NaiveSolution(string s, int k)
    {
        int totalCount = 0;

        for (int i = 0; i < s.Length; i++)
        {
            var str = new StringBuilder();
            for (int j = i; j < s.Length; j++)
            {
                str.Append(s[j]);
                if (str.Length >= k)
                {
                    if (CountUniqueElements(str.ToString()) == k) 
                    {
                        totalCount++;
                    }
                }
            }
        }
        return totalCount;
    }

    private static int CountUniqueElements(string s)
    {
        var set = new HashSet<char>();

        foreach (char c in s)
        {
            set.Add(c);
        }
        return set.Count;
    }

    // Time: O(n^2)
    // Space: Space: O(26) coz at max 26 characters can be present in array, which can be considered as constant space
    private static int NaiveSolutionII(string str, int k)
    {
        // Initialize result
        int res = 0;
 
        int n = str.Length;
 
        // To store count of characters from 'a' to 'z'
        int[] cnt = new int[26];
 
        // Consider all substrings beginning with
        // str[i]
        for (int i = 0; i < n; i++)
        {
            int dist_count = 0;
 
            // Initializing count array with 0
            Array.Clear(cnt, 0,cnt.Length);
 
            // Consider all substrings between str[i..j]
            for (int j=i; j<n; j++)
            {
                // If this is a new character for this
                // substring, increment dist_count.
                if (cnt[str[j] - 'a'] == 0)
                    dist_count++;
 
                // Increment count of current character
                cnt[str[j] - 'a']++;
 
                // If distinct character count becomes k,
                // then increment result.
                if (dist_count == k)
                    res++;
            }
        }
 
        return res;
 
    }

    // Time: O(n^2)
    // Space: O(26) coz at max 26 characters can be present in hashset, which can be considered as constant space
    public static int NaiveSolutionIII(string s, int k)
    {
        var set = new HashSet<char>();
        long totalCount = 0;

        for (int i = 0; i < s.Length; i++)
        {
            set.Clear();

            for (int j = i; j < s.Length; j++)
            {
                set.Add(s[j]);
                if (set.Count > k) break;
                else if (set.Count == k) totalCount++;
            }
        }
        return (int)totalCount;

    }
    
    public static int OptimalSolution(string s, int k)
    {
        return FindSubstringUptoKDistict(s, k) - FindSubstringUptoKDistict(s, k - 1);
    }

    // Time Complexity: O(n)
    // Auxiliary Space: O(1)
    private static int FindSubstringUptoKDistict(string s, int k)
    {
        // Array to store the frequency of characters in the current substring
        var arr = new int[26];
        int left = 0;
        int distinct = 0;
        int num = 0;

        for (int i = 0; i < s.Length; i++)
        {
            arr[s[i] - 'a']++;

            // If the frequency becomes 1, a new distinct character is added
            if (arr[s[i] - 'a'] == 1) distinct++;

            // While the number of distinct characters exceeds k, move the left pointer
            while (distinct > k)
            {
                arr[s[left] - 'a']--;

                // If the frequency becomes 0, a distinct character is removed
                if (arr[s[left] - 'a'] == 0) distinct--;
                left++;
            }

              // Add the count of num with at most k distinct characters
            num = num + (i - left + 1);
        }
        return num;
    }

}
