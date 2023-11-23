using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class ContinuousAlphabetPyramid
    {
        public static void Print(int row)
        {
            var base64A = 65;
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write((char)base64A);
                    base64A++;
                }
                Console.WriteLine();
            }
        }
    }
}
