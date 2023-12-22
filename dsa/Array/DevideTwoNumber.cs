using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public static class DevideTwoNumber
    {
        // You are given two number A and B
        // devide A with B and return answer
        // do not use /, use binary search

        public static void Solution(int a, int b)
        {
            var output = BinarySearchSolution(Math.Abs(a), Math.Abs(b));
            if (a < 0 && b > 0 || a > 0 && b < 0)
            {
                Console.WriteLine(output * -1);
            }
            else
            {
                Console.WriteLine(output);
            }
            
        }

        private static int BinarySearchSolution(int a, int b)
        {
            // Logic
            // a / b = result
            // try to find b * result == a
            // find result using binary search

            if (a == b) return 1;
            int start = 0;
            int end = int.Max(a, b);
            int ans = -1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (mid * b == a)
                {
                    return mid;
                }
                else if (mid * b > a)
                {
                    end = mid - 1;
                }
                else
                {
                    ans = mid;
                    start = mid + 1;
                }
            }
            return ans;
        }
    }
}
