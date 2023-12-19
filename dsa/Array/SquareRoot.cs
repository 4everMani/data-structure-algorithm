using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public static class SquareRoot
    {
        public static void Solution(int x)
        {
            Console.WriteLine(BinarySearchSolution(x));
        }

        private static int BinarySearchSolution(int x)
        {
            long start = 0;
            long end = x/2;

            int ans = -1;
            while (start <= end)
            {
                long mid = start + (end - start) / 2;
                long midSquare = mid * mid;
                if (x == 1)
                {
                    return 1;
                }
                if (midSquare == x)
                {
                    return (int)mid;
                }
                else if (midSquare > x)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                    ans = (int)mid;
                }
            }
            return ans;
        }
    }
}
