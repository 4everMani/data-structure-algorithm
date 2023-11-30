using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class HollowInvertedHalfPyramid
    {
        public static void Print(int n)
        {
            for (int row = 0; row < n; row++) 
            {
                for(int col = 0; col < n - row; col++) 
                {
                    if(col == 0 || col == (n-row) - 1 || row == 0)
                    {
                        Console.Write("*");
                    }
                    else { Console.Write(" "); }
                }
                Console.WriteLine();
            }
        }
    }
}
