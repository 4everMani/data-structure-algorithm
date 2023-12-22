using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class BinarySearchIn2DMatrix
    {
        public static void Solution(int[][] matrix, int target)
        {
            var output = BinarySolution(matrix, target);
            foreach ( var i in output )
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
        }

        private static int[] BinarySolution(int[][] matrix, int target)
        {
            int start = 0;
            int end = matrix.Length * matrix[0].Length - 1;

            while (start <= end) 
            {
                int mid = start + (end - start) / 2;
                int rowIndex = mid / matrix[0].Length;
                int colIndex = mid % matrix[0].Length;

                if (matrix[rowIndex][colIndex] == target)
                {
                    return new int[] { rowIndex, colIndex };
                }
                else if (matrix[rowIndex][colIndex] > target)
                {
                    end = mid - 1;
                }
                else { start = mid + 1; }
            }
            return new int[] {-1, -1};
        }
    }
}
