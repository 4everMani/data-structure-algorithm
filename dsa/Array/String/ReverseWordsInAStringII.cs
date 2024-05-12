

namespace String;

public class ReverseWordsInAStringII
{

    // input => "manish jaiswal"
    // output => "jaiswal manish"

    // First reverse each word
    // then reverse each character or reverse entire list from index 0 to n - 1;
    public static void Solution(string s)
    {
        System.Console.WriteLine(OptimalSolution(s));
    }

    private static string OptimalSolution(string s)
    {
        var arr = s.ToArray();

        int end = 0;
        int start = 0;
        while (end < arr.Length)
        {
            if (s[end] == ' ') 
            {
                Reverse(arr, start, end - 1);
                start = end + 1;
            }
            else if (end == arr.Length - 1) Reverse(arr, start, end);
            end++;
        }
        Reverse(arr, 0, end - 1);
        return string.Concat(arr);
    }

    private static void Reverse(char[] s, int start, int end)
    {
        while (start <= end)
        {
            (s[start], s[end]) = (s[end], s[start]);
            start++;
            end--;
        }
    }
}


