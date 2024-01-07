using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class EkoSPOJ
    {
        public static void Solution(long[] heights, long woodRequired)
        {
            Console.WriteLine(BinarySolution(heights, woodRequired));
        }
        private static long BinarySolution(long[] heights, long woodRequired)
        {
            long start = 1;
            long end = heights.Max();
            long ans = -1;

            while (start <= end)
            {
                long mid = start + (end - start) / 2;
                bool isValidHeight = ValidateHeight(heights, woodRequired, mid);
                if (isValidHeight)
                {
                    ans = mid;
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return ans;
        }

        private static bool ValidateHeight(long[] heights, long woodRequired, long maximumHeight)
        {
            long woodToGet = 0;

            for (int i = 0; i < heights.Length; i++)
            {
                long woodToCut = heights[i] - maximumHeight;
                if (woodToCut > 0)
                {
                    woodToGet += woodToCut;

                    if (woodToGet >= woodRequired) return true;
                }
            }
            return woodToGet >= woodRequired;
        }
    }
}
