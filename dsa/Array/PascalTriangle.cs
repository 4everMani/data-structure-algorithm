using System;
using System.Collections.Generic;
using System.Xml.Schema;

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
        //PrintElementGivenRowAndColumn(5, 3);

        // 2) Given row number, give all row elements
        //PrintGivenRow(4);

        // 3) Given entire Pascal Triangle given a number
        List<List<int>> res = PascalTrianglePattern(num);

        foreach (var nums in res)
        {
            foreach (var val in nums)
            {
                System.Console.Write(val + ", ");
            }
            System.Console.WriteLine();
        }
    }

    private static List<List<int>> PascalTrianglePattern(int num)
    {
        // as we know each row has equal number of column
        // if num = 5 then row will be start from 1 to 5 and each row will contain col 1 to 5.
        // therefore we can use PrintElementGivenRowAndColumn() for naive solution
        // Time complexity will be nearly O(n *n * n)
        // first 2 n for row and column and last n for finding the element;


        // we will use PrintGivenRow() method
        // Time: O(n * n) nearly
        var output = new List<List<int>>();

        for (int i = 1; i <= num; i++)
        {
            output.Add(PrintGivenRow(i));

        }
        return output;
    }

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

    // Time: O(row)
    private static List<int> PrintGivenRow(int row)
    {
        // We know that evey row contains element equal to row number.
        // e.g. if row is 5 then it will have 5 element => [1,4,6,4,1]
        // therefore loop will run from 1 to row;

        // Since we know the row number and total number of column(equal to row)
        // we can use method PrintElementGivenRowAndColumn(), but it will take O(n) for finding every element
        // Total compalexity will be O(row * n)

        // We will need different solution

        var list = new List<int>();
        list.Add(1);

        for (int i = 1; i < row; i++)
        {
            var product = list[i - 1] * (row - i);
            var element = product / i;
            list.Add(element);
        }

        //foreach(var element in list)
        //{
        //    Console.Write(element + ",");
        //}

        return list;

    }
}
