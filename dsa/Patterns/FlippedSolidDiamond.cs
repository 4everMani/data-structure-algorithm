using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class FlippedSolidDiamond
    {
        public static void Print(int n)
        {
            // printing first half
            for (int row = 0; row < n; row++) 
            {
                // printing star
                for(int col = 0; col < n - row; col++)
                {
                    Console.Write("*");
                }
                // printing space
                for (int col = 0; col < (2*row + 1);  col++)
                {
                    Console.Write(" ");
                }
                // printing star
                for (int col = 0; col < n - row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(); ;
            }

            // printing second half
            for (int row = 0; row < n; row++)
            {
                // printing star
                for (int col = 0; col < row + 1; col++)
                {
                    Console.Write("*");
                }
                //printing space
                for (int col = 0; col < ((2 * n) - (2 * row + 1)); col++)
                {
                    Console.Write(" ");
                }
                //// printing star
                for (int col = 0; col < row + 1; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(); ;
            }

        }
    }
}
