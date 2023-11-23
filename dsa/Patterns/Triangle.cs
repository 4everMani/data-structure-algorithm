using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class Triangle
    {
        //public static void Print(int row)
        //{
        //    for (int i = 0; i < row; i++)
        //    {
        //        for (int j = 0; j <= (row - 1) + i; j++) 
        //        {
        //            if ((i + j) >= row - 1)
        //            {
        //                Console.Write("* ");
        //                Console.Write("  ");
        //                j += 1;
        //            }
        //            else
        //            {
        //                Console.Write("  ");
        //            }
        //        }
        //        Console.WriteLine();
        //    }
        //}
        public static void Print(int row)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row - (i + 1); j++)
                {
                    Console.Write("  ");
                }
                for (int j = 0; j < (i + 1); j++)
                {
                    Console.Write("*   ");
                }
                Console.WriteLine();
            }

        }
    }
}
