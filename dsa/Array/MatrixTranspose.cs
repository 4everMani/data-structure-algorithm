using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class MatrixTranspose
    {
        //public static void Print(int[,] matrix, int size)
        //{
        //    var transposeArray = new int[matrix.GetLength(0),matrix.GetLength(1)];

        //    for (int i = 0;  i < matrix.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matrix.GetLength(1); j++)
        //        {
        //            transposeArray[j,i] = matrix[i,j];
        //        }
        //    }

        //    for (int i = 0; i < transposeArray.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < transposeArray.GetLength(1); j++)
        //        {
        //            Console.Write(transposeArray[i,j] + " ");
        //        }
        //        Console.WriteLine();
        //    }

        //}

        public static void Print(int[,] matrix)
        {
            for (int i = 0;  i < matrix.GetLength(0); i++)
            {
                for(int j = i; j < matrix.GetLength(1); j++)
                {
                    (matrix[j, i], matrix[i, j]) = (matrix[i, j], matrix[j, i]);
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
