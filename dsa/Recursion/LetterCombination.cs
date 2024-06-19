
namespace Recursion;

using System;
using System.Text;

public class LetterCombination
{
    public static void Solution(string digits)
    {
        LetterCombinations(digits);
    }

    private static IList<string> LetterCombinations(string digits) {
        var result = new List<string>();
        if (string.IsNullOrEmpty(digits)) return result;

        var digitToLetters = new Dictionary<char, string> {
            {'2', "abc"},
            {'3', "def"},
            {'4', "ghi"},
            {'5', "jkl"},
            {'6', "mno"},
            {'7', "pqrs"},
            {'8', "tuv"},
            {'9', "wxyz"}
        };

        Backtrack(digits, 0, [], result, digitToLetters);
        return result;
    }

    private static void Backtrack(string digits, int index, List<char> currentCombination, List<string> result, Dictionary<char, string> digitToLetters) 
    {
        if (index == digits.Length) {
            result.Add(new string(currentCombination.ToArray()));
            return;
        }

        string possibleLetters = digitToLetters[digits[index]];
        foreach (char letter in possibleLetters) {
            currentCombination.Add(letter);
            Backtrack(digits, index + 1, currentCombination, result, digitToLetters);
            currentCombination.RemoveAt(currentCombination.Count - 1);
        }
    }
}