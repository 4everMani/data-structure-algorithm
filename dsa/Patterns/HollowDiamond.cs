using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class HollowDiamond
    {
        public static void Print(int n)
        {
            // Print first hollow pyramid
            for(int row = 0; row < n; row++)
            {
                // Printing space
                for(int col = 0; col < n - row -1; col++)
                {
                    Console.Write(" ");
                }
                // Printing star
                for (int col = 0; col < (2 * row) + 1; col++)
                {
                    // Prining first and last position
                    if(col == 0 || col == 2*row)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            // Print second hollow pyramid
            for (int row = 0; row < n; row++)
            {
                // Printing space
                for (int col = 0; col < row ; col++)
                {
                    Console.Write(" ");
                }
                // Printing star
                for (int col = 0; col < (2 * n) - (2 * row) - 1; col++)
                {
                    // Prining first and last position
                    if (col == 0 || col == 2 * n - (2 * row) - 2)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
