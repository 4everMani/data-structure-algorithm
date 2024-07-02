

namespace DP;

public class WildCardMatching
{

    // Given an input string (s) and a pattern (p), implement wildcard pattern matching with support for '?' and '*' where: '?' Matches any single character.
    // '*' Matches any sequence of characters (including the empty sequence).
    // The matching should cover the entire input string (not partial).

    // Example 1:
    // Input: s = "aa", p = "a"
    // Output: false
    // Explanation: "a" does not match the entire string "aa".
    
    // Example 2:
    // Input: s = "aa", p = "*"
    // Output: true
    // Explanation: '*' matches any sequence.
   
    // Example 3:
    // Input: s = "cb", p = "?a"
    // Output: false
    // Explanation: '?' matches 'c', but the second letter is 'a', which does not match 'b'.

    public static void Solution(string s, string p)
    {
        System.Console.WriteLine(IsMatch(s, p));
    }


    // Recursive Solution
    public static bool IsMatch(string s, string p) {
        return Helper(s, p, s.Length - 1, p.Length - 1);
    }
    private static bool Helper(string s, string p, int inds, int indp)
    {
        if (inds < 0 && indp < 0) return true;
        if (indp < 0 && inds >= 0) return false;
        if (inds < 0 && indp >= 0 )
        {
            if (p[indp] == '*') return Helper(s, p, inds, indp - 1);
            else return false;
        } 
        // if character mathces or character is '?'
        if (p[indp] == '?' || p[indp] == s[inds]) return Helper(s, p, inds - 1, indp - 1);
        // if character is '*'
        if (p[indp] == '*')
        {
            return Helper(s, p, inds, indp - 1) || Helper(s, p, inds - 1, indp);
        } 
        return false;
    }


    // Memoized Solution
    public static bool IsMatchII(string s, string p) {
        int[][] dp = new int[s.Length][];
        for (int i = 0; i < s.Length; i++)
        {
            dp[i] = new int[p.Length];
            Array.Fill(dp[i], -1);
        }
        return HelperII(s, p, s.Length - 1, p.Length - 1, dp);
    }
    private static bool HelperII(string s, string p, int inds, int indp, int[][] dp)
    {
        if (inds < 0 && indp < 0) return true;
        if (indp < 0 && inds >= 0) return false;
        if (inds < 0 && indp >= 0 )
        {
            if (p[indp] == '*') 
            {
                return HelperII(s, p, inds, indp - 1, dp);
            }
            else return false;
        } 
        if (dp[inds][indp] != -1) return dp[inds][indp] == 1;
        // if character mathces or character is '?'
        if (p[indp] == '?' || p[indp] == s[inds])
        {
            var res = HelperII(s, p, inds - 1, indp - 1, dp);
            dp[inds][indp] = res ? 1 : 0;
            return res;
        }
        // if character is '*'
        if (p[indp] == '*')
        {
            var res = HelperII(s, p, inds, indp - 1, dp) || HelperII(s, p, inds - 1, indp, dp);
            dp[inds][indp] = res ? 1 : 0;
            return res;
        } 
        dp[inds][indp] = 0;
        return false;
    }

    // Iterative Solution (bottom up appraoch)
    public static bool IsMatchIII(string s, string p) {
        bool[][] dp = new bool[s.Length + 1][];
        for (int i = 0; i <= s.Length; i++)
        {
            dp[i] = new bool[p.Length + 1];
        }

        // initializing when pattern is empty and string is empty
        dp[0][0] = true;
        // initializing first row (string is empty, pattern is not)
        for (int i = 1; i <= p.Length; i++)
        {
            if (p[i - 1] == '*') dp[0][i] = dp[0][i - 1];
        }
        // initializing first column (pattern is empty,  string is not)
        // by default bool[] will be false, therfore I am not initializing

        for (int i = 1; i <= s.Length; i++)
        {
            for (int j = 1; j <= p.Length; j++)
            {
                if (p[j - 1] == '?' || p[j - 1] == s[i - 1])
                {
                    dp[i][j] = dp[i - 1][j - 1];
                }
                if (p[j - 1] == '*')
                {
                    dp[i][j] = dp[i - 1][j] || dp[i][j - 1];
                }
            }
        }
        return dp[s.Length][p.Length];
    }
    
    
    // Space optimized bottiom up
    public static bool IsMatch4(string s, string p) {
        bool[] prev = new bool[p.Length + 1];
        bool[] curr = new bool[p.Length + 1];

        // inititalizing when patten and string both are empty
        prev[0] = true;
        // initializing first row(string is empty patter is not)
        for (int i = 1; i <= p.Length; i++)
        {
            if (p[i - 1] == '*') prev[i] = prev[i - 1];
        }

        for (int i = 1; i <= s.Length; i++)
        {
            for (int j = 1; j <= p.Length; j++)
            {
                if (s[i - 1] == p[j - 1] || p[j - 1] == '?') curr[j] = prev[j - 1];
                else if (p[j - 1] == '*') curr[j] = curr[j - 1] || prev[j];
            }
            for (int m = 0; m <= p.Length; m++)
            {
                prev[m] = curr[m];
                curr[m] = false;
            }
        }
        return prev[p.Length];
    }
}
