namespace DP;

public class RegularExpressionMatching
{
    // Given an input string s and a pattern p, implement regular expression matching with support for '.' and '*' where:

    // '.' Matches any single character.​​​​
    // '*' Matches zero or more of the preceding element.
    // The matching should cover the entire input string (not partial).

    

    // Example 1:
    // Input: s = "aa", p = "a"
    // Output: false
    // Explanation: "a" does not match the entire string "aa".
    
    // Example 2:
    // Input: s = "aa", p = "a*"
    // Output: true
    // Explanation: '*' means zero or more of the preceding element, 'a'. Therefore, by repeating 'a' once, it becomes "aa".
    
    // Example 3:
    // Input: s = "ab", p = ".*"
    // Output: true
    // Explanation: ".*" means "zero or more (*) of any character (.)".

    public static void Solution(string s, string p)
    {
        System.Console.WriteLine(IsMatchIV(s,p));
    }

    // Recursive Solution
    public static bool IsMatch(string s, string p) {
        

        return Helper(s,p, s.Length - 1, p.Length - 1);
        
    }

    public static bool Helper(string s, string p, int i, int j)
    {
        // when string and pattern both are empty
        if (i < 0 && j < 0) return true;
        // when pattern is empty but string is not
        if (i >=0 && j < 0) return false;
        // when string is empty but pattern is not
        if (i < 0 && j >= 0)
        {
            if (p[j] == '*')
            {
                return Helper(s, p, i, j - 2);
            }
            return false; 
        }
        
        // character matches or '.'
        if (s[i] == p[j] || p[j] == '.')
        {
            return Helper(s, p, i - 1, j - 1);
        }
        // character is *
        if (p[j] == '*')
        {
            if (Helper(s, p, i, j - 2)) return true;
            if (s[i] == p[j - 1] || p[j - 1] == '.')
            {
                return Helper(s, p, i - 1, j);
            }
            return false;
        }
        return false;
    }

    // Memoized Solution
    public bool IsMatchII(string s, string p) {
        
        int[][] dp = new int[s.Length][];
        for (int i = 0; i < s.Length; i++)
        {
            dp[i] = new int[p.Length];
            Array.Fill(dp[i], -1);
        }
        return HelperII(s,p, s.Length - 1, p.Length - 1, dp);
        
    }

    public bool HelperII(string s, string p, int i, int j, int[][] dp)
    {
        if (i < 0 && j < 0) return true;
        if (i >=0 && j < 0) return false;
        if (i < 0 && j >= 0)
        {
            if (p[j] == '*')
            {
                return HelperII(s, p, i, j - 2, dp);
            }
            return false; 
        }

        if (dp[i][j] != -1)
        {
            Console.WriteLine(i);
            return dp[i][j] == 1;
        } 
        if (s[i] == p[j] || p[j] == '.')
        {
            var res = HelperII(s, p, i - 1, j - 1, dp);
            dp[i][j] = res ? 1 : 0;
            return res;
        }
        if (p[j] == '*')
        {
            if (HelperII(s, p, i, j-2, dp))
            {
                dp[i][j] = 1;
                return true;
            }
            if (s[i] == p[j - 1] || p[j-1] == '.')
            {
                var res = HelperII(s, p, i - 1, j, dp);
                dp[i][j] = res ? 1 : 0;
                return res;
            }
           
        }
        dp[i][j] = 0;
        return false;
    }
 

    // Iterative solution
     public bool IsMatchIII(string s, string p) {
        bool[][] dp = new bool[s.Length + 1][];
        for (int i = 0; i <= s.Length; i++)
        {
            dp[i] = new bool[p.Length + 1];
        }

        // if string and pattern is empty
        dp[0][0] = true;
        // if string is empty but pattern is not
        for (int j = 1; j <= p.Length; j++)
        {
            if(p[j - 1] == '*') dp[0][j] = dp[0][j - 2];
        }
        // if pattern is empty but string is not
        // Not setting first coulmn as false coz
        // default value of bool[] is false;



        for (int i = 1; i <= s.Length; i++)
        {
            for (int j = 1; j <= p.Length; j++)
            {
                // matching characters or there is a '.' in pattern
                if (s[i - 1] == p[j - 1] || p[j - 1] == '.') dp[i][j] = dp[i-1][j-1];
                // if pattern has *
                else if (p[j - 1] == '*')
                {
                    
                    // matches zero preceding element
                    if (dp[i][j-2])  dp[i][j] = true;

                    // matches more than zero preceding element
                    else if(s[i - 1] == p[j - 2] || p[j-2] == '.') dp[i][j] = dp[i - 1][j];
                }
                else dp[i][j] = false;
            }
        }
        return dp[s.Length][p.Length];
        
    }

    public static bool IsMatchIV(string s, string p) {
        int n = s.Length;
        int m = p.Length;

        bool[] prev = new bool[m + 1];
        bool[] curr = new bool[m + 1];

        // if string and pattern is empty
        prev[0] = true;
        // if string is empty but pattern is not
        for (int j = 1; j <= m; j++)
        {
            if(p[j - 1] == '*') prev[j] = prev[j - 2];
        }
        // if pattern is empty but string is not
        // Not setting first coulmn as false coz
        // default value of bool[] is false;



        for (int i = 1; i <= s.Length; i++)
        {
            for (int j = 1; j <= p.Length; j++)
            {
                // matching characters or there is a '.' in pattern
                if (s[i - 1] == p[j - 1] || p[j - 1] == '.') curr[j] = prev[j-1];
                // if pattern has *
                else if (p[j - 1] == '*')
                {
                    
                    // matches zero preceding element
                    if (curr[j-2])  curr[j] = true;

                    // matches more than zero preceding element
                    else if(s[i - 1] == p[j - 2] || p[j-2] == '.') curr[j] = prev[j];
                }
                else curr[j] = false;
            }
            for (int j = 0; j <= m; j++)
            {
                prev[j] = curr[j];
                curr[j] = false;
            }
        }
        return prev[m];
        
    }
}
