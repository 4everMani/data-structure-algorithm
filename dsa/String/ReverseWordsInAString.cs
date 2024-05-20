
using System.Text;

namespace String;

public class ReverseWordsInAString
{
    // Given an input string s, reverse the order of the words.
    // A word is defined as a sequence of non-space characters. The words in s will be separated by at least one space.
    // Return a string of the words in reverse order concatenated by a single space.
    // Note that s may contain leading or trailing spaces or multiple spaces between two words. The returned string should only have a single space separating the words. Do not include any extra spaces.

    // Example 1:
    // Input: s = "the sky is blue"
    // Output: "blue is sky the"
    
    // Example 2:
    // Input: s = "  hello world  "
    // Output: "world hello"
    // Explanation: Your reversed string should not contain leading or trailing spaces.
    
    // Example 3:
    // Input: s = "a good   example"
    // Output: "example good a"
    // Explanation: You need to reduce multiple spaces between two words to a single space in the reversed string.

    public  static void Solution(string input)
    {
        // System.Console.Write(OptimalSolution(input));

        // System.Console.WriteLine(Bruteforece(input));
        System.Console.WriteLine(BestSolution(input));
    }

    

    // Time: O(n)
    // Space: O(n) for output
    private static string OptimalSolution(string input)
    {
        var output = string.Empty;

        int i = input.Length - 1;
        int j = i;
        
        while (i >= -1)
        {

            if (i < 0) 
            {
                if (input.Substring(i + 1, j - i) != string.Empty)
                    output += input.Substring(i + 1, j - i);
                i--;
            }
            else if (input[i] == ' ' && input[j] == ' ')
            {
                i--;
                j--;
            }
            else if (input[i] == ' ' && input[j] != ' ')
            {
                output += input.Substring(i + 1, j - i);
                output += ' ';
                j = i;
            }
            else 
            {
                i--;
            }
        }
        return output.TrimEnd();
    }

    private static string Bruteforece(string input)
    {
        var output = string.Empty;
        var stack = new Stack<string>();
        var i = 0;
        var j = 0;

        while(j <= input.Length)
        {
            if (j == input.Length)
            {
                if (input[i..j] != string.Empty) stack.Push(input[i..j]);
                j++;
            }
            else if (input[i] == ' ' && input[j] == ' ') 
            {
                i++;
                j++;
            }
            else if (input[i] != ' ' && input[j] == ' ')
            {
                stack.Push(input[i..j]);
                i = j;
            }
            else j++;
        }

        while (stack.Count > 1)
        {
            output += stack.Pop();
            output += " ";
        }
        output += stack.Pop();
        return output;

    }

    private static string BestSolution(string s)
    {
        var list = new List<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (list.Count == 0 && s[i] == ' ') continue;
            else if (list.Count > 1 && list[list.Count - 1] == ' ' && s[i] == ' ') continue;
            else list.Add(s[i]);
        }

        // Reversing each word
        var start = 0;
        var end = 0;
        for(; end < list.Count; end++)
        {
            if (list[end] == ' ')
            {
                Reverse(list, start, end -1);
                start = end + 1;
            }
            else if (end == list.Count - 1) Reverse(list, start, end);
        }
        Reverse(list, 0, end - 1);
        var str = new StringBuilder();
        int j = list[0] == ' ' ? 1 : 0;
        for (; j < list.Count; j++)
        {
            str.Append(list[j]); 
        }
        return str.ToString();
    }

    private static void Reverse(List<char> list, int start, int end)
    {
        while (start <= end)
        {
            (list[start], list[end]) = (list[end], list[start]);
            start++;
            end--;
        }
    }
}







