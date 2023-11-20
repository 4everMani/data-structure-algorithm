using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class SolidRectangle
    {
        // Print a solid rectangle with given rows and columns

        public static void Print(int row, int column)
        {
            for (int i = 0; i< row; i++)
            {
                for(int j = 0; j< column; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

    }
}
