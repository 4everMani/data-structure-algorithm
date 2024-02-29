using System;
using System.Collections.Generic;

namespace Array;

public class SetMetrixZeros
{
    // Given an m x n integer matrix matrix, if an element is 0, set its entire row and column to 0's.
    // You must do it in place.

    // Example 1:

    // Input: matrix = [[1,1,1],[1,0,1],[1,1,1]]
    // Output: [[1,0,1],[0,0,0],[1,0,1]]

    // Example 2:
    // Input: matrix = [[0,1,2,0],[3,4,5,2],[1,3,1,5]]
    // Output: [[0,0,0,0],[0,4,5,0],[0,3,1,0]]

    public static void Solution(int[][] matrix)
    {
        // int[][] result = NaiveSolution(matrix);
        // int[][] result = BetterSolution(matrix);
        int[][] result = OptimalSolution(matrix);

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                Console.Write(result[i][j] + " ");
            }
            System.Console.WriteLine();
        }
    }

    // Time: O(n*m) * O(n + m) + O(n*m) nearly O(n^3)
    // Space : O(n*m)
    private static int[][] NaiveSolution(int[][] matrix)
    {
        var tempMat = new int[matrix.Length,matrix[0].Length];

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (matrix[i][j] == 0)
                {
                    MakeMatrixZero(matrix, i , j, tempMat);
                }
            }
        }

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (tempMat[i,j] == int.MinValue)
                {
                    matrix[i][j] = 0;
                }
            }
        }
        return matrix;
    }


    // Time: O(n*m) + O(n*m)
    // Space: O(m) + O(n) => n = row and m = col
    private static int[][] BetterSolution(int[][] matrix)
    {
        var rowList = new int[matrix.Length];
        var colList = new int[matrix[0].Length];

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (matrix[i][j] == 0)
                {
                    rowList[i] = -1;
                    colList[j] = -1;
                }
            }
        }

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (rowList[i] == -1 || colList[j] == -1)
                {
                    matrix[i][j] = 0;
                }
            }
        }

        return matrix;

    }
    
    

    // Time: O(n * m) + O((n-1) * (m-1)) + O(n) + O(m) => O(2(n * m))
    private static int[][] OptimalSolution(int[][] matrix)
    {
        // var rowList = new int[matrix.Length];
        // var colList = new int[matrix[0].Length];
        // we will use first row and col as our hasing array
        var col = 1;

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (matrix[i][j] == 0)
                {
                    matrix[i][0] = 0;
                    if (j != 0) matrix[0][j] = 0;
                    else col = 0;
                }
            }
        }

        for (int i = 1; i < matrix.Length; i++)
        {
            for (int j = 1; j < matrix[0].Length; j++)
            {
                if (matrix[0][j] == 0 || matrix[i][0] == 0)
                {
                    matrix[i][j] = 0;
                }
            }
        }

        if (matrix[0][0] == 0)
        {
            for (int i = 0; i < matrix[0].Length; i++)
            {
                matrix[0][i] = 0;
            }
        }

        if (col == 0)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i][0] = 0;
            }
        }


        return matrix;

    }
    
    
    private static void MakeMatrixZero(int[][] matrix, int row, int col, int[,] tempMat)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            tempMat[i,col] = int.MinValue;
        }

        for (int i = 0; i < matrix[0].Length; i++)
        {
            tempMat[row,i] = int.MinValue;
        }
    }
}
