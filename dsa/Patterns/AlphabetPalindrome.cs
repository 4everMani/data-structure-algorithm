using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class AlphabetPalindrome
    {
        public static void Print(int n)
        {
            for (int row = 0; row < n; row++)
            {
                var baseAscii = 65;
                for (int col = 0; col < 2*row + 1; col++)
                {
                    Console.Write((char)(baseAscii));
                    baseAscii = col < row ? baseAscii + 1 : baseAscii-1;
                   
                }
                Console.WriteLine();
            }
        }
    }
}
