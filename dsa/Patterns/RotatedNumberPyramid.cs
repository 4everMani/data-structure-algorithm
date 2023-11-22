using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class RotatedNumberPyramid
    {
        public static void Print(int row)
        {
            
            for (int i = 0; i < row; i++)
            {
                var count = i + 1;
                for (int j = 0; j < row; j++)
                {
                    if ((j + i) >= (row - 1))
                    {
                        Console.Write($"{count} ");
                        count++;
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
