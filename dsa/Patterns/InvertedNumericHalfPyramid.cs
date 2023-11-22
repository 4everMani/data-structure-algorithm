using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class InvertedNumericHalfPyramid
    {
        public static void Print(int row)
        {
            for (int i = 0; i < row; i++)
            {
                for(int j = 0; j < row - i; j++)
                {
                    Console.Write(j + 1 + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
