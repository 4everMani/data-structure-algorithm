using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class HollowPattern
    {
        // Print hollow pattern, means only outer part will have star printed.

        public static void Print(int row, int column)
        {
            for(int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if(i == 0 || i == row - 1)
                    {
                        Console.Write("* ");
                    }
                    else if(j == 0 || j == column - 1)
                    {
                        Console.Write("* ");
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
