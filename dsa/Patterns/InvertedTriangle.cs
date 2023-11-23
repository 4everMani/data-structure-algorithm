using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class InvertedTriangle
    {
        public static void Print(int row)
        {
            for(int i = 0; i < row; i++)
            {
                // for printing space
                for(int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }

                // for printing "*"

                for(int k = 0; k < row - i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        //public static void Print(int row)
        //{
        //    var isRowEven = false;
        //    for (int i = 0; i < row; i++)
        //    {
        //        isRowEven = i == 0 || i % 2 == 0;
        //        for (int j = 0; j < ((row * 2) - 1) - i; j++)
        //        {
        //            var isColEven = j == 0 || j % 2 == 0;
        //            if (isColEven == isRowEven)
        //            {
        //                if (j >= i)
        //                {
        //                    Console.Write("* ");
        //                }
        //                else
        //                {
        //                    Console.Write("  ");
        //                }
        //            }
        //            else
        //            {
        //                Console.Write("  ");
        //            }
        //        }
        //        Console.WriteLine();
        //    }
        //}
    }
}
