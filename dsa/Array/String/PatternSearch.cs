
namespace String;

public class PatternSearch
{
    // You will be given a string s having length n and another string t with length m.
    // You need to find the occurance of t in s.

    // Input: s => "Geeksforgeeks"
    //        t => "eks"
    // Output: at index 2 and 10

    // Input: s => "ABCCSCD"
    //        t => "BCC"
    // Output: at index 1

    public static void Solution(string s, string t)
    {
        // List<int> output = NaiveSolution(s, t);
        List<int> output = NaiveSolutionII(s, t);
        System.Console.WriteLine(string.Join(' ', output).ToString());
    }

    // Time: O(n - m + 1) * O(m) 
    // This Naive solution will work for every pattern
    private static List<int> NaiveSolution(string s, string t)
    {
        var list = new List<int>();
        int n = s.Length;
        int m = t.Length;
        for (int i = 0; i <= n - m; i++)
        {
            if (s[i] == t[0])
            {
                for (int j = 1; j < m; j++)
                {
                    if (s[j+i] == t[j])
                    {
                        if (j == m - 1) list.Add(i);
                    }
                    else break;
                }
            }
        }
        return list;
    }

    // Improved Naive Solution for distinct character in target string(t)
    // Input: s => "Geeksforgeeks"
    //        t => "eks" (characters will be unique always)
    // Output: at index 2 and 10

    // Input: s => "ABCCABEFABCD"
    //        t => "ABCD" (characters will be unique always)
    // Output: at index 8

    // Logic: we will not start from next element if some match found. 
    // we will start from where again where matching failed
    // in second example: mathcing is found from index 0 till 2nd index, 
    // so first iteration will be 0 and second iteraiton will be from 3rd index coz this is where matching were broken.
    // this logic can be implement coz target string has distinct characters

    // Time: O(n) coz we are skipping elements when match found.
    public static List<int> NaiveSolutionII(string s, string t)
    {
        List<int> list = [];
        int n = s.Length;
        int m = t.Length;
        for (int i = 0; i <= n - m; )
        {
            int j;
            for (j = 0; j < m; j++)
            {
                if (s[i + j] != t[j]) break;
                if ( j == m - 1) list.Add(i);
            }
            if (j != 0) i += j;
            else i++;
        }
        return list;
    }

    // Rabin karp alogorithm for string searching (or pattern matching)
    // Input: s => "abdabcbabc"
    //        t => "abc" 
    // Output: at index 3 and 7

    // Input: s => "aaaaa"
    //        t => "aaa" (characters will be unique always)
    // Output: at index 0, 1 and 2

    // In worst case it can also have Quadratic time complexity like first Naive solution
    // But in general it works better.
    // public static List<int> RabinKarpSolution(string s, string t)
    // {

    // }

}
