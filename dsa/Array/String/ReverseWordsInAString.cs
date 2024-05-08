
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
        // System.Console.WriteLine(OptimalSolution(input));
        System.Console.WriteLine(Bruteforece(input));
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
                stack.Push(input[i..j]);
                break;
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
        
        return output.TrimStart();

    }
}







