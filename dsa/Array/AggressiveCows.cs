using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class AggressiveCows
    {
        public static void Solution(int[] slots, int n, int noOfCows)
        {
            Console.WriteLine(Solve(slots, n, noOfCows));
        }

        private static int Solve(int[] slots, int n, int noOfCows)
        {
            int end = slots.Max();
            int start = 0;
            int ans = -1;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                bool isValidPosition =  IsValidSolution(slots, n, noOfCows, mid);
                if (isValidPosition)
                {
                    ans = mid > ans || ans == -1 ? mid : ans;
                    start = mid + 1;
                   
                }
                else
                end = mid - 1;
            }
            return ans;
        }

        private static bool IsValidSolution(int[] slots, int n, int noOfCows, int distance)
        {
            
            int counter = 1;
            int position = slots[0];

            for (int i = 1; i < n; i++)
            {
                if (slots[i] - position >= distance)
                {
                    counter++;
                    position = slots[i];
                }
                if (counter == noOfCows) return true;
            }

            
            return false;
        }
    }
}
