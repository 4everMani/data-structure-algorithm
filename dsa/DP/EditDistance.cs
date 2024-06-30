namespace DP;

public class EditDistance
{
    // Given two strings word1 and word2, return the minimum number of operations required to convert word1 to word2.
    // You have the following three operations permitted on a word:
    // Insert a character
    // Delete a character
    // Replace a character
    

    // Example 1:
    // Input: word1 = "horse", word2 = "ros"
    // Output: 3
    // Explanation: 
    // horse -> rorse (replace 'h' with 'r')
    // rorse -> rose (remove 'r')
    // rose -> ros (remove 'e')
    
    // Example 2:
    // Input: word1 = "intention", word2 = "execution"
    // Output: 5
    // Explanation: 
    // intention -> inention (remove 't')
    // inention -> enention (replace 'i' with 'e')
    // enention -> exention (replace 'n' with 'x')
    // exention -> exection (replace 'n' with 'c')
    // exection -> execution (insert 'u')


    // Recursive solution
    public static int Helper(string s1, string s2, int ind1, int ind2)
    {
        if (ind1 >= s1.Length) return s2.Length - ind2;
        else if (ind2 >= s2.Length) return s1.Length - ind1;
        else if (s1[ind1] == s2[ind2]) 
            return Helper(s1, s2, ind1 + 1, ind2 + 1);
        else 
        {

            return 1 + Math.Min(Math.Min(Helper(s1, s2, ind1 + 1, ind2 + 1), Helper(s1, s2, ind1, ind2 + 1)), 
                        Helper(s1, s2, ind1 + 1, ind2));
            // replace
            // 1 + Helper(s1, s2, ind1 + 1, ind2 + 1);

            // // insert s2's character to s1
            // 1 + Helper(s1, s2, ind1, ind2 + 1);

            // // delete from s1
            // 1 + Helper(s1, s2, ind1 + 1, ind2);
            
        }
    }

    // Memoized Solution using 2-D Array
    public int MinDistance(string word1, string word2) {
        int[][] dp = new int[word1.Length][];

        for (int i = 0; i < word1.Length; i++)
        {
            dp[i] = new int[word2.Length];
            Array.Fill(dp[i], -1);
        }
        return HelperII(word1, word2, 0, 0, dp);
    }
    public int HelperII(string s1, string s2, int ind1, int ind2, int[][] dp)
    {
        if (ind1 >= s1.Length) return s2.Length - ind2;
        else if (ind2 >= s2.Length) return s1.Length - ind1;
        else if (dp[ind1][ind2] != -1) return dp[ind1][ind2];
        else if (s1[ind1] == s2[ind2]) 
            return dp[ind1][ind2] = HelperII(s1, s2, ind1 + 1, ind2 + 1, dp);
        else 
        {

            return dp[ind1][ind2] = 1 + Math.Min(Math.Min(HelperII(s1, s2, ind1 + 1, ind2 + 1, dp), HelperII(s1, s2, ind1, ind2 + 1, dp)), 
                        HelperII(s1, s2, ind1 + 1, ind2, dp));
            // replace
            // 1 + Helper(s1, s2, ind1 + 1, ind2 + 1);

            // // insert s2's character to s1
            // 1 + Helper(s1, s2, ind1, ind2 + 1);

            // // delete from s1
            // 1 + Helper(s1, s2, ind1 + 1, ind2);
            
        }
    }

    // Iterative solution with 2-D Array
    public static int MinDistanceII(string word1, string word2) {
        int[][] dp = new int[word1.Length + 1][];

        // initializing 2-D array
        for (int i = 0; i <= word1.Length; i++)
        {
            dp[i] = new int[word2.Length + 1];
        }
        // filling first row
         for (int i = 0; i <= word2.Length; i++)
        {
            dp[0][i] = i;
        }

        // filling first column
         for (int i = 0; i <= word1.Length; i++)
        {
            dp[i][0] = i;
        }

        for (int i = 1; i <= word1.Length; i++ )
        {
            for (int j = 1; j <= word2.Length; j++)
            {
                if (word1[i - 1] == word2[j - 1])
                {
                    dp[i][j] = dp[i - 1][j - 1];
                }
                else
                {
                    dp[i][j] = 1 + Math.Min(Math.Min(dp[i - 1][j - 1], dp[i - 1][j]), dp[i][j - 1]);
                }

            }
        }

        return dp[word1.Length][word2.Length];
    }

    // Iterative solution without 2-D Array
    public int MinDistanceIII(string word1, string word2) {
        int n = word1.Length;
        int m = word2.Length;
        int[] current = new int[m + 1];
        int[] previous = new int[m + 1];

        for (int i = 1; i <= m ; i++)
        {
            previous[i] = i;
        }

        for (int i = 1; i <= n; i++ )
        {
            current[0] = i;
            for (int j = 1; j <= m; j++)
            {
                if (word1[i - 1] == word2[j - 1])
                {
                    current[j] = previous[j - 1];
                }
                else
                {
                    current[j] = 1 + Math.Min(Math.Min(current[j - 1], previous[j - 1]), previous[j]);
                }

            }
            for (int k = 0; k <= m; k++)
            {
                previous[k] = current[k];
            }
        }
        return previous[m];
    }
}
