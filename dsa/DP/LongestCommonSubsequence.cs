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
        System.Console.WriteLine(FindLongestCommonSubsequence(text1, text2));
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
}





