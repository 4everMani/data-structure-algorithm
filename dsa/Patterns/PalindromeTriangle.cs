using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class PalindromeTriangle
    {
        public static void Print(int row)
        {
            for (int i = 0; i < row; i++)
            {
                var count = i + 1;
                for (int j = 0; j <= (row - 1) + i; j++)
                {
                    if ((i + j) >= row - 1)
                    {
                        Console.Write($"{count} ");
                        _ = (row - 1) - j <= 0 ? count-- : count++;
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
