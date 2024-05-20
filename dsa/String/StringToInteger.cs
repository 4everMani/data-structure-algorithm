
using System.Text;

namespace String;

public class StringToInteger
{
// implement the myAtoi(string s) function, which converts a string to a 32-bit signed integer.

// The algorithm for myAtoi(string s) is as follows:

// Whitespace: Ignore any leading whitespace (" ").
// Signedness: Determine the sign by checking if the next character is '-' or '+', assuming positivity is neither present.
// Conversion: Read the integer by skipping leading zeros until a non-digit character is encountered or the end of the string is reached. If no digits were read, then the result is 0.
// Rounding: If the integer is out of the 32-bit signed integer range [-231, 231 - 1], then round the integer to remain in the range. Specifically, integers less than -231 should be rounded to -231, and integers greater than 231 - 1 should be rounded to 231 - 1.
// Return the integer as the final result.

 

// Example 1:
// Input: s = "42"
// Output: 42
// Explanation:
// The underlined characters are what is read in and the caret is the current reader position.
// Step 1: "42" (no characters read because there is no leading whitespace)
//          ^
// Step 2: "42" (no characters read because there is neither a '-' nor '+')
//          ^
// Step 3: "42" ("42" is read in)
//            ^

// Example 2:
// Input: s = " -042"
// Output: -42
// Explanation:
// Step 1: "   -042" (leading whitespace is read and ignored)
//             ^
// Step 2: "   -042" ('-' is read, so the result should be negative)
//              ^
// Step 3: "   -042" ("042" is read in, leading zeros ignored in the result)
//                ^

// Example 3:
// Input: s = "1337c0d3"
// Output: 1337
// Explanation:
// Step 1: "1337c0d3" (no characters read because there is no leading whitespace)
//          ^
// Step 2: "1337c0d3" (no characters read because there is neither a '-' nor '+')
//          ^
// Step 3: "1337c0d3" ("1337" is read in; reading stops because the next character is a non-digit)
//              ^

// Example 4:
// Input: s = "0-1"
// Output: 0
// Explanation:

// Step 1: "0-1" (no characters read because there is no leading whitespace)
//          ^
// Step 2: "0-1" (no characters read because there is neither a '-' nor '+')
//          ^
// Step 3: "0-1" ("0" is read in; reading stops because the next character is a non-digit)
//           ^

// Example 5:
// Input: s = "words and 987"
// Output: 0
// Explanation:
// Reading stops at the first non-digit character 'w'.

    public static void Solution(string s)
    {
        System.Console.WriteLine(OptimalSolution(s));
    }

    private static int NaiveSolution(string s)
    {
        var str = new StringBuilder();

        foreach(char i in s)
        {
            if (i == '-') 
            {
                if (str.Length == 0) str.Append(i);
                else break;
            }
            else if(str.Length == 0 && (i == ' ')) continue;
            else
            {
                int num;
                var isNum = int.TryParse(i.ToString(), out num);
                if (!isNum) break;
                str.Append(num);
            }
        }
        if (str.Length > 0)
        {
            long number = long.Parse(str.ToString());
            var result = unchecked((int)number);
            return result;
        }
        return 0;
    }

    private static int OptimalSolution(string s)
    {
        var sign = 1;
        long ans = 0;
        int index = 0;
        // removing whitespace
        while(index < s.Length && s[index] == ' ')
        {
            index++;
        }

        //  checking if there is any sign
        if (index + 1 < s.Length)
        {
            if(s[index] == '-' || s[index] == '+')
            {
                sign = s[index] == '-' ? -1 : 1;
                index++;
            }
        }
        // this method is also correct
        // for (;index < s.Length ; index++)
        // {
        //     int num;
        //     var isNum = int.TryParse(s[index].ToString(), out num);
        //     if (!isNum) break;
        //     ans = sign == -1 ? (ans * 10) - num : (ans * 10) + num;
        //     if (ans > int.MaxValue) return int.MaxValue;
        //     else if (ans < int.MinValue) return int.MinValue;
        // }

        // this is faster
        for (;index < s.Length ; index++)
        {
            var num = (int)s[index];
            if (num > 57 || num < 48) break;
            else
            {
                int number = int.Parse(s[index].ToString());
                ans = sign == -1 ? (ans * 10) - number : (ans * 10) + number;
                if (ans > int.MaxValue) return int.MaxValue;
                else if (ans < int.MinValue) return int.MinValue;
            }
        }
        
        return (int)ans;
    }
}
