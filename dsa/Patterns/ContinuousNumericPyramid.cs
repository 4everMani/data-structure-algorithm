using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class ContinuousNumericPyramid
    {
        public static void Print(int row)
        {
            var count = 1;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if(j <= i)
                    {
                        Console.Write($"{count} ");
                        count++;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
