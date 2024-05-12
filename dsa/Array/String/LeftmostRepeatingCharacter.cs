
namespace String;

public class LeftmostRepeatingCharacter
{
    // The problem statement is as follows: Given a string consisting of lowercase English alphabets, 
    // we need to find the index of first repeating character in the string. 
    // If there are no repeating characters, we should return -1.

    // "abccb" => 1
    // "abcd" => -1
    // "geeksforgeeks" => 0

    public static void Solution(string input)
    {
        System.Console.WriteLine(NaiveSolution(input));
        System.Console.WriteLine(BetterSolution(input));
        System.Console.WriteLine(OptimalSolution(input));
        System.Console.WriteLine();
    }

    // Time: O(n^2)
    private static int NaiveSolution(string input)
    {
        for (int i = 0; i < input.Length; i++)
        {
            for (int j = i + 1; j < input.Length; j++)
            {
                if (input[j] == input[i]) return i;
            }
        }
        return -1;
    }

    // Time: O(2n)
    // Space: O(n)
    private static int BetterSolution(string input)
    {
        var dict = new Dictionary<char, int>();

        foreach (char s in input)
        {
            if (!dict.ContainsKey(s)) dict.Add(s, 1);
            else dict[s] += 1;
        }

        for (int i = 0; i < input.Length; i++)
        {
            if (dict.ContainsKey(input[i]) && dict[input[i]] > 1) return i;
        }
        return -1;
    }

    // Time: O(n)
    // Space: O(n)
    private static int OptimalSolution(string input)
    {
        var dict = new Dictionary<char, int>();
        var index = int.MaxValue;

        for (int i = 0; i < input.Length; i++)
        {
            if (!dict.ContainsKey(input[i])) dict.Add(input[i], i);
            else 
            {
                index = Math.Min(index, dict[input[i]]);
            }
        }
        return index == int.MaxValue ? -1 : index;
    }
}
