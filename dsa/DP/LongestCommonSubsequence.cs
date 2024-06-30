namespace DP;

public class LongestCommonSubsequence
{

    // Given two strings text1 and text2, return the length of their longest common subsequence. 
    // If there is no common subsequence, return 0.
    // A subsequence of a string is a new string generated from the original string with 
    // some characters (can be none) deleted without changing the relative order of the remaining characters.

    // For example, "ace" is a subsequence of "abcde".
    // A common subsequence of two strings is a subsequence that is common to both strings.

    

    // Example 1:
    // Input: text1 = "abcde", text2 = "ace" 
    // Output: 3  
    // Explanation: The longest common subsequence is "ace" and its length is 3.
    
    // Example 2:
    // Input: text1 = "abc", text2 = "abc"
    // Output: 3
    // Explanation: The longest common subsequence is "abc" and its length is 3.
    
    // Example 3:
    // Input: text1 = "abc", text2 = "def"
    // Output: 0
    // Explanation: There is no such common subsequence, so the result is 0.
    
    public static void Solution(string text1, string text2)
    {
        // System.Console.WriteLine(FindLongestCommonSubsequence(text1, text2));
        // System.Console.WriteLine(FindLCS(text1, text2));
        System.Console.WriteLine(OptimizedCode(text1, text2));
    }

    public static int FindLongestCommonSubsequence(string text1, string text2) {
        int[][] mat = new int[text1.Length][];
        for (int i = 0; i < text1.Length; i++)
        {
            mat[i] = new int[text2.Length];
            Array.Fill(mat[i], -1);
            
        }
        return Helper(text1, text2, 0, 0, mat);
    }

    private static int Helper(string text1, string text2, int ind1, int ind2, int[][] dp)
    {
        if (ind1 >= text1.Length || ind2 >= text2.Length)
        {
            return 0;
        }
        else if (dp[ind1][ind2] != -1) return dp[ind1][ind2];
        else if (text1[ind1] == text2[ind2])
        {
            return dp[ind1][ind2] = 1 + Helper(text1, text2, ind1 + 1, ind2 + 1, dp);
        }
        else
        {
            return dp[ind1][ind2] = Math.Max(Helper(text1, text2, ind1 + 1, ind2, dp), Helper(text1, text2, ind1, ind2 + 1, dp));
        }
    }

    // iterative solution
    private static int FindLCS(string text1, string text2)
    {
        int n = text1.Length;
        int m = text2.Length;

        int[][] dp = new int[n + 1][];
        for (int i = 0; i <= n; i++)
        {
            dp[i] = new int[m + 1];
            Array.Fill(dp[i], 0);
        }

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= m; j++)
            {
                if (text1[i - 1] == text2[j - 1])
                {
                    dp[i][j] = 1 + dp[i - 1][j - 1];
                }
                else
                {
                    dp[i][j] = Math.Max(dp[i][j - 1], dp[i - 1][j]);
                }
            }
        }
        return dp[n][m];
    }

    private static int OptimizedCode(string text1, string text2)
    {
        int n = text1.Length;
        int m = text2.Length;
        int[] prevArr = new int[m + 1];
        Array.Fill(prevArr, 0);
        int[] currArr = new int[m + 1];
        Array.Fill(currArr, 0);

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= m; j++)
            {
                if (text1[i - 1] == text2[j - 1])
                {
                    currArr[j] = 1 + prevArr[ j - 1];
                }
                else
                {
                    currArr[j] = Math.Max(currArr[j - 1], prevArr[j]);
                }
            }

            for (int j = 1; j <= m; j++)
            {
                prevArr[j] = currArr[j];
                currArr[j] = 0;
            }
        }
        return prevArr[m];
    }
}
