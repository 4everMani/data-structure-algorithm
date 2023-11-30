using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class HollowFullPyramid
    {
        public static void Print(int n)
        {
            for (int row = 0; row < n - 1; row++)
            {
                // printing space
                for(int col = 0; col < n - row -1; col++)
                {
                    Console.Write(" ");
                }

                // printing star
                for(int col = 0;col < 2 * row + 1; col++) 
                { 
                    if(col == 0 || col == 2 * row)
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
            for (int row = 0; row < 1; row++)
            {
                // printing star
                for (int col = 0; col < 2*n; col++)
                {
                    if(col % 2 == 0)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    
                }
            }
        }
    }
}
