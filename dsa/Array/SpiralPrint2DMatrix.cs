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
    }
}
