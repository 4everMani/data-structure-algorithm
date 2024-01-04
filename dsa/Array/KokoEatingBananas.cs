using System;
using System.Linq;

namespace Array
{
    public class KokoEatingBananas
    {
        //Koko loves to eat bananas.There are n piles of bananas,
        //the ith pile has piles[i] bananas.
        //The guards have gone and will come back in h hours.
        //Koko can decide her bananas-per-hour eating speed of k.
        //Each hour, she chooses some pile of bananas and eats k bananas from
        //that pile.If the pile has less than k bananas, she eats all of them
        //instead and will not eat any more bananas during this hour.
        //Koko likes to eat slowly but still wants to finish eating all
        //the bananas before the guards return.

        //Return the minimum integer k such that she can eat all the bananas
        //within h hours.

        //Example 1:

        //Input: piles = [3, 6, 7, 11], h = 8
        //Output: 4
        //Example 2:

        //Input: piles = [30, 11, 23, 4, 20], h = 5
        //Output: 30
        //Example 3:

        //Input: piles = [30, 11, 23, 4, 20], h = 6
        //Output: 23

        public static void Solution(int[] piles, int hour)
        {
            Console.WriteLine(MinEatingSpeed(piles, hour));
        }
        public static int MinEatingSpeed(int[] piles, int h)
        {
            int start = 1;
            int end = piles.Max();
            int ans = -1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                bool validSpeed = IsValidSpeed(piles, h, mid);
                if (validSpeed)
                {
                    ans = mid;
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return ans;
        }

        private static bool IsValidSpeed(int[] piles, int h, int speed)
        {
            int hourCount = 0;
            for (int i = 0; i < piles.Length; i++)
            {
                int hourTaken = 0;
                hourTaken += (piles[i] / speed);
                hourTaken += (piles[i] % speed) != 0 ? 1 : 0;
                if (hourCount + hourTaken > h) return false;
                else
                {
                    hourCount += hourTaken;
                }
            }
            return true;
        }
    }
}
