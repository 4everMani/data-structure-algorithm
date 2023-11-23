using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class AlphabetPyramid
    {
        public static void Print(int row)
        {
             var baseAscii = 65;
            for(int i = 0; i <= row - 1; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write((char)(baseAscii + i));
                }
                Console.WriteLine();
            }
        }
    }
}
