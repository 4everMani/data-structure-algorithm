using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class SpiralPrint2DMatrix
    {
        public static void Solution(int[][] arr)
        {
            int startRow = 0;
            int endRow = arr.Length - 1;
            int startCol = 0;
            int endCol = arr[0].Length - 1;
            int index = 0;

            while (index < (arr.Length * arr[0].Length))
            {
                // printing first row
                for (int i = startCol; i <= endCol; i++)
                {
                    if (index >= (arr.Length * arr[0].Length))
                    {
                        break;
                    }
                    Console.Write(arr[startRow][i]);
                    index ++;
                }
                startRow++;
                // printing end col
                for (int j = startRow; j <= endRow; j++)
                {
                    if (index >= (arr.Length * arr[0].Length))
                    {
                        break;
                    }
                    Console.Write(arr[j][endCol]);
                    index ++;
                }
                endCol--;
                // printing end row
                for (int k = endCol; k >= startCol; k--)
                {
                    if (index >= (arr.Length * arr[0].Length))
                    {
                        break;
                    }
                    Console.Write(arr[endRow][k]);
                    index++;
                }
                endRow--;
                // printing first col
                for (int l = endRow; l >= startRow; l--)
                {
                    if (index >= (arr.Length * arr[0].Length))
                    {
                        break;
                    }
                    Console.Write(arr[l][startCol]);
                    index++;
                }
                startCol++;
            }
        }
        public static IList<int> SolutionII(int[][] matrix)
        {
             var top = 0;
            var bottom = matrix.Length - 1;
            var left = 0;
            var right = matrix[0].Length - 1;
            IList<int> output = new List<int>();

            while (top <= bottom && left <= right)
            {
                // moving left to right
                for (int i = left; i <= right; i++)
                {
                    output.Add(matrix[top][i]);
                }
                top++;

                // moving top to bottom
                for (int i = top; i <= bottom; i ++)
                {
                    output.Add(matrix[i][right]);
                }
                right--;

                // moving right to left
                if (top <= bottom)
                {
                    for (int i = right; i >= left ; i--)
                    {
                        output.Add(matrix[bottom][i]);
                    }
                    bottom--;
                }
            
                // moving bottom to top
                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--)
                    {
                        output.Add(matrix[i][left]);
                    }
                    left++;
                }
            }
            return output;
        }
    }
}


