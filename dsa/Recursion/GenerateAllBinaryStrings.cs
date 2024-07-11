namespace Recursion;
using System.Text;
using System.Collections.Generic;

public class GenerateAllBinaryString
{

    // Given an integer, K. Generate all binary strings of size k without consecutive 1’s.

    // Examples: 
    // Input : K = 3  
    // Output : 000 , 001 , 010 , 100 , 101 
    // Input : K  = 4 
    // Output :0000 0001 0010 0100 0101 1000 1001 1010

	public static void Solution(int size)
	{
        var output = GenerateAllStrings(size); 
        foreach (var str in output)
        {
            Console.WriteLine(str);
        }
    }

    // Time: O(2^n)
    // Space: O(n)
    public static List<string>  GenerateAllStrings(int size)
    {
        List<string> output = new();
        StringBuilder str = new();
        for (int i = 0; i < size; i++)
        {
            str.Append('0');
        }
        Helper(str, output, 0);
        return output;
    }

    private static void Helper(StringBuilder str, List<string> output, int ind)
    {
        if (ind >= str.Length) 
        {
            var s = new string(str.ToString());
            output.Add(s);
            return;
        }

        if (ind > 0 && str[ind - 1] == '1')
        {
            str[ind] = '0';
            Helper(str, output, ind + 1);
        }
        else
        {
            // Pick elements
            str[ind] = '1';
            Helper(str, output, ind + 1);

            // Not Pick
            str[ind] = '0';
            Helper(str, output, ind + 1);
        }


    }

    private static bool IsValid(StringBuilder str)
    {
        for (int i = 1; i < str.Length; i++)
        {
            if (str[i - 1] == '1' && str[i] == '1') return false;
        }
        return true;
    }

}
