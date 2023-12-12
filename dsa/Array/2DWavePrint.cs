using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class WavePrint
    {
        public static void Solution(int[][] arr)
        {
            Solution1(arr);
            Console.WriteLine();
            Improved(arr);
        }
        public static void Solution1(int[][] arr)
        {
            int i = 0;
            int j = 0;
            int control = 0;
            int index = 0;
            int totalElements = 0;
            foreach (int[] subArr in arr)
            {
                totalElements += subArr.Length;
            }
            while(index < totalElements)
            {
                if (control == 0)
                {
                    Console.Write(arr[i][j] + " ,");
                    i++;
                    if (i == 3)
                    {
                        control = 2;
                        i--;
                        j++;
                    }
                }
                else if (control == 2)
                {
                    Console.Write(arr[i][j] + " ,");
                    i--;
                    if (i == -1)
                    {
                        control = 0;
                        i++;
                        j++;
                    }
                }
                index++;
            }
        }

        public static void Improved(int[][] arr)
        {
            int row = arr.Length;
            int col = arr[0].Length;

            for (int j = 0; j < col; j++)
            {
                if ((j & 1) ==0)
                {
                    for (int i = 0; i < row; i++)
                    {
                        Console.Write(arr[i][j] + " ,");
                    }
                }
                else
                {
                    for (int i = row - 1; i >= 0; i--)
                    {
                        Console.Write(arr[i][j] + " ,");
                    }
                }
            }
        }
    }
}
