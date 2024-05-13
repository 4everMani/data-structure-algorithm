using System.Text;

namespace String;

public class LongestCommonPrefix
{
    // Write a function to find the longest common prefix string amongst an array of strings.
    // If there is no common prefix, return an empty string "".

    // Example 1:
    // Input: strs = ["flower","flow","flight"]
    // Output: "fl"
    
    // Example 2:
    // Input: strs = ["dog","racecar","car"]
    // Output: ""
    // Explanation: There is no common prefix among the input strings.

    public static void Solution(string[] strs)
    {
        Console.WriteLine(OptimalSolution(strs));
    }

    // Time: O(n * m)
    // n => length of array
    // m => minimum length of string in array
    public static string NaiveSolution(string[] strs)
    {
        if (strs.Length == 1) return strs[0];
        var maxCount = strs.Min(s => s.Length);
        var output = new StringBuilder();
        
        for (int i = 0; i < maxCount; i++)
        {	
            var  key = strs[0][i];
            int j;
            for (j = 1; j < strs.Length; j++)
            {
                if(key == strs[j][i]) continue;
                else  break;
            }
            if (j == strs.Length) output.Append(strs[0][i]);
            else break;
        }
        return  output.ToString();
    }

    // Time: O(nlogn m + 2m)
    //Sorting a list of things is only O(n log n) if it is O(1) work to compare 2 things. 
    //For strings ordered lexographically, we start comparing the first character and keep going up to the end. 
    //In the worst case, all m characters are needed to do 1 comparisons.
    //Since the worst case cost of comparing two strings is m, 
    //then the worst case sorting here is O(nlogn * m), then there is the additional 2*m scan to compare the first and last. 
    // So the runtime for this solution is O(nlogn m + 2m).
    public static string OptimalSolution(string[] strs)
    {
        var output = new StringBuilder();
        Array.Sort(strs);

        for (int i = 0; i < Math.Min(strs[0].Length, strs[^1].Length); i++)
        {
            if (strs[0][i] == strs[^1][i]) output.Append(strs[0][i]);
            else break;
        }
        return output.ToString();
    }

}
