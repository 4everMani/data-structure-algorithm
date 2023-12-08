using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class RotateImage
    {

        //You are given an n x n 2D matrix representing an image, rotate the image by 90 degrees(clockwise).
        //You have to rotate the image in-place, which means you have to modify the input 2D matrix directly.DO NOT allocate another 2D matrix and do the rotation
        //Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
        //Output: [[7,4,1],[8,5,2],[9,6,3]]

        public static void Solution(int[][] matrix)
        {
            // transposing the matrix
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = row; col < matrix[row].Length; col++)
                {
                    if (row != col)
                    {
                        (matrix[row][col], matrix[col][row]) = (matrix[col][row], matrix[row][col]);
                    }
                }
            }

            // reversing each row
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = matrix[row].Reverse().ToArray();
                //int left = 0;
                //int right = matrix[row].Length - 1;
                //while (left < right)
                //{
                //    (matrix[row][left], matrix[row][right]) = (matrix[row][right], matrix[row][left]);
                //    left++;
                //    right--;
                //}
                
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
