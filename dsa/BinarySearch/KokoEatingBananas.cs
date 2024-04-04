namespace BinarySearch;

public class KokoEatingBananas
{
    // Koko loves to eat bananas. There are n piles of bananas, the ith pile has piles[i] bananas. The guards have gone and will come back in h hours.
    // Koko can decide her bananas-per-hour eating speed of k. Each hour, she chooses some pile of bananas and eats k bananas from that pile. 
    //If the pile has less than k bananas, she eats all of them instead and will not eat any more bananas during this hour.
    // Koko likes to eat slowly but still wants to finish eating all the bananas before the guards return.
    // Return the minimum integer k such that she can eat all the bananas within h hours.

    

    // Example 1:
    // Input: piles = [3,6,7,11], h = 8
    // Output: 4

    // Example 2:
    // Input: piles = [30,11,23,4,20], h = 5
    // Output: 30

    // Example 3:
    // Input: piles = [30,11,23,4,20], h = 6
    // Output: 23



    public static void Solution(int[] piles, int h)
    {
        int res = MinEatingSpeed(piles, h);
    }
    public static int MinEatingSpeed(int[] piles, int h) {
        int maxSpeed = piles.Max();
        int minSpeed = 1;
        int speed = 0;
        while (minSpeed <= maxSpeed)
        {
            int mid = minSpeed + (maxSpeed - minSpeed) / 2;
            if (CanEat(piles, h, mid))
            {
                speed = mid;
                maxSpeed = mid - 1;
            }
            else minSpeed = mid + 1;
        }

        return speed;
    }

    private static bool CanEat(int[] piles, int h, int speed)
    {
        int hoursTaken = 0;

        for (int i = 0; i < piles.Length; i++)
        {
            hoursTaken += piles[i] / speed;
            if (piles[i] % speed > 0) hoursTaken++;

            if (hoursTaken > h) return false;
        }
        return true;
    }

}
