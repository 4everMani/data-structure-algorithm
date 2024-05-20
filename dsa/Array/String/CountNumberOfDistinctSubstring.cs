
using System.Text;

namespace String;

public class CountNumberOfDistinctSubstring
{
    public static void Solution(string s)
    {
        System.Console.WriteLine(NaiveSolution(s));
    }

    // Time: O(n^2)
    // Space: O(n) for string and O(n*l) 
    // l = (avg. length of string stored in hashmap coz every string will have it's own length)
    // Since we have extra overhead of length of every string store in hashmap, we can get MLE(Memorey Limit Exceed) upon executing application
    private static int NaiveSolution(string s)
    {
        var set = new HashSet<string>();

        for (int i = 0; i < s.Length; i++)
        {
            var str = new StringBuilder();
            for (int j = i; j < s.Length; j++)
            {
                str.Append(s[j]);
                set.Add(str.ToString());
            }
        }
        return set.Count;
    }
    
    // Time: O(n^2)
    // Space: O(n) for string and O(n) for hashmap
    // Now we are storing long in hashmap which is fine 
    private static int OptimalSolution(string s)
    {
        double mod = 1e9 + 7; // ten to the power 9 + 7
        var set = new HashSet<long>();
        for (int i = 0; i < s.Length; i++)
        {
            long p = 1;
            long hash = 0;
            var str = new StringBuilder();

            for (int j = i; j < s.Length; j++)
            {
                // applying hashing
                hash = (long)((hash + ((s[j] - 'a')*p)%mod)%mod);
                p = (long)((p * 31)%mod);
                set.Add(hash);
            }
        }
        return set.Count;
    }
}
