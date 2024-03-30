using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public static class Test
    {
        public static void Solution(int[][] nums)
        {
            SetZeroes(nums);
        }

        public static void SetZeroes(int[][] matrix)
        {
            var n = matrix.Length;
            var m = matrix[0].Length;
            var copy = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        SetRowColumn(copy, i, j, n, m);
                    }
                    else
                    {
                        copy[i, j] = matrix[i][j];
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i][j] = copy[i, j];
                }
            }
        }

        public static void SetRowColumn(int[,] matrix, int row, int column, int n, int m)
        {

            // making row zero
            for (int j = 0; j < m; j++)
            {
                matrix[row, j] = 0;
            }

            // making column zero
            for (int i = 0; i < n; i++)
            {
                matrix[i, column] = 0;
            }


        }


    }
}
