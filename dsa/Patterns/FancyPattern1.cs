using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class FancyPattern1
    {

        //1
        //2*2
        //3*3*3
        //4*4*4*4
        //4*4*4*4
        //3*3*3
        //2*2
        //1

        public static void Print(int n)
        {
            for (int row = 0; row < n; row++)
            {
                for(int col = 0; col < row + 1; col++)
                {
                    if (col == 0)
                    {
                        Console.Write(row + 1);
                    }
                    else
                    {
                        Console.Write($"*{row + 1}");
                    }
                }
                Console.WriteLine();
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n - row; col++)
                {
                    if (col == 0)
                    {
                        Console.Write(n - row);
                    }
                    else
                    {
                        Console.Write($"*{(n - row)}");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
