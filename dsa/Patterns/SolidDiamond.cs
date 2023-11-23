using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class SolidDiamond
    {
        // for totalRow = given row * 2
        public static void Print(int n)
        {
            // Printing full pyramid
            for(int row = 0; row < n; row++)
            {
                for(int col = 0; col < n - 1 - row; col++)
                {
                    Console.Write(" ");
                }
                for (int col = 0; col < row + 1; col++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }

            // Printing inverted pyramid
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < row; col++)
                {
                    Console.Write(" ");
                }
                for (int col = 0; col < n - row; col++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }
        // for totlRow = given row
        //public static void Print(int row)
        //{
        //    var half = (int)Math.Floor(row / 2.0);
        //    for(int i = 0; i < row; i++)
        //    {
        //        // Printing first half of diamond
        //        if(i < half)
        //        {
        //            // Printing space
        //            for(int j = 0; j < half - 1 - i; j++)
        //            {
        //                Console.Write(" ");
        //            }
        //            // Printing "*"
        //            for (int k = 0; k < i + 1; k++)
        //            {
        //                Console.Write("* ");
        //            }
        //        }
        //        // Printing second part
        //        else
        //        {
        //            // Printing space
        //            for (int l = 0; l < i - half; l++)
        //            {
        //                Console.Write(" ");
        //            }
        //            // Printing "*"
        //            for (int m = 0; m < row - i; m++)
        //            {
        //                Console.Write("* ");
        //            }
        //        }
        //        Console.WriteLine();
        //    }
        //}
    }
}
