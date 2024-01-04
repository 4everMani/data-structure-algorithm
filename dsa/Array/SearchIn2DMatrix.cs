using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class SearchIn2DMatrix
    {

        //You are given an m x n integer matrix matrix with the following two properties:

        //Each row is sorted in non-decreasing order.
        //The first integer of each row is greater than the last integer of the previous row.
        //Given an integer target, return true if target is in matrix or false otherwise.

        //You must write a solution in O(log(m* n)) time complexity.

        public static void Solution(int[][] matrix, int target)
        {
            Console.WriteLine(SearchMatrix(matrix, target));
        }
        public static bool SearchMatrix(int[][] matrix, int target)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            if (target < matrix[0][0] || target > matrix[m - 1][n - 1])
            {
                return false;
            }

            // applying binary search to find row
            int startRow = 0;
            int endRow = m - 1;
            while (startRow <= endRow)
            {
                int mid = startRow + (endRow - startRow) / 2;
                if (matrix[mid][0] == target) return true;
                if (matrix[mid][0] > target) endRow = mid - 1;
                else startRow = mid + 1;
            }

            // applying binary search to find column
            int startCol = 0;
            int endCol = n - 1;
            while (startCol <= endCol)
            {
                int mid = startCol + (endCol - startCol) / 2;
                if (matrix[endRow][mid] == target) return true;
                if (matrix[endRow][mid] > target) endCol = mid - 1;
                else startCol = mid + 1;
            }
            return false;
        }
    }
}
