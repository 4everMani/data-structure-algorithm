namespace DP;

public class PalindromicSubstrings
{
    public static void Solution(string s)
    {
        CountSubstrings(s);
    }

    public static int CountSubstrings(string s) {
        int[] arr = new int[1];
        // Helper(s, arr, 0, "");
        // GenerateSubstrings(s, "", 0, new List<string>());
        HelperII(s, arr, 0, new List<char>());
        return arr[0];
    }

    private static void Helper(string s, int[] arr, int ind, string curr)
    {
        if (ind >= s.Length)
        {
            System.Console.WriteLine(curr);
            // if (curr.Count > 0 && IsPalindrome(curr))
            // {
            //     arr[0] += 1;
            // }
            return;
        }
        
        Helper(s, arr, ind + 1, curr);
        Helper(s, arr, ind + 1, curr + s[ind]);
        // curr.RemoveAt(curr.Count - 1);

    }

    static void GenerateSubstrings(string s, string current, int start, List<string> result)
    {
        if (start == s.Length)
        {
            return;
        }

        for (int i = start; i < s.Length; i++)
        {
            current += s[i];
            result.Add(current);
            GenerateSubstrings(s, current, i + 1, result);
            current = current.Substring(0, current.Length - 1);
        }

    }

    private static void HelperII(string s, int[] arr, int ind, List<char> curr)
    {
        // if (ind >= s.Length)
        // {
        //         System.Console.WriteLine(string.Join(",", curr.ToArray()));
        //     if (curr.Count > 0 && IsPalindrome(curr))
        //     {
        //         arr[0] += 1;
        //     }
        //     return;
        // }
        for (int i = ind; i < s.Length; i++)
        {
            curr.Add(s[i]);
            System.Console.WriteLine(string.Join(",", curr.ToArray()));
            // arr[0] += 1;
            HelperII(s, arr, i + 1, curr);
            curr.RemoveAt(curr.Count - 1);
        }
    }

    private static bool IsPalindrome(List<char> s)
    {
        int n = s.Count;
        if (n == 1) return true;
        int i = 0;
        int j = n - 1;

        while(i < j)
        {
            if(s[i] != s[j]) return false;
            i++;
            j--;
        }
        return true;
    }
}
