using System;
using System.Collections.Generic;

namespace Array;

public class PascalTriangle
{

    // In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:
    // Example 1:

    // Input: numRows = 5
    // Output: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]
    // Example 2:

    // Input: numRows = 1
    // Output: [[1]]

    public static void Solution(int num)
    {
        // There are 3 variety of questions can be asked in interview
        // 1) Given row and colulmn number, give the element
        PrintElementGivenRowAndColumn(5, 3);

        // 2) Given row number, give all row elements
        
        // 3) Given entire Pascal Triangle given a number
        // List<List<int>> res = PascalTrianglePattern(num);

        // foreach(var nums in res)
        // {
        //     foreach(var val in nums)
        //     {
        //         System.Console.Write(val + ", ");
        //     }
        //     System.Console.WriteLine();
        // }
    }

    // private static List<List<int>> PascalTrianglePattern(int num)
    // {
    //     var output = new List<List<int>>();

    //     for (int i = 0; i < num; i++)
    //     {

    //     }
    // }

    private static void PrintElementGivenRowAndColumn(int row, int col)
    {
        // There is a formulae using which we can find
        // the element at given row and colulmn number.
        // formulae => nCr
        // n = row - 1, r = column - 1
        // element = nCr = n! / (r!) * (n-r)!
        // time complexity will be => O(n) + O(r) + O(n - r)

        // we can also have a short cut to calculate the value of nCr.
        // if row = 7 and col = 3.
        // then n = row - 1 and r = col - 1;
        // result = 6/1 * 5 / 2;
        // time complexity will be => O(n)

        // Solution
        var num = 1;
        row -= 1;
        col -= 1;
        for (int i = 0; i < col; i++)
        {
            num *= row - i;
            num /= (i + 1);
        }
        System.Console.WriteLine(num);
    }
}
