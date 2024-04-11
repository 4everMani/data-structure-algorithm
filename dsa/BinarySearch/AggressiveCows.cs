

namespace BinarySearch;

public class AggressiveCows
{
    public static void Solution(int[] coordinates, int numberOfCows)
    {
        int result = OptimalSolution(coordinates, numberOfCows);
        Console.WriteLine(result);
    }

    private static int OptimalSolution(int[] coordinates, int numberOfCows)
    {
        Array.Sort(coordinates);
        int minimumDistance = 1; // distance should be atlease 1 bw two cows
        int maximumDistance = coordinates.Max() - coordinates.Min(); // maximum distance is when we will have only two cows and c1 will be in first stall and c2 will be in last stall
        int ans = -1;

        while (minimumDistance <= maximumDistance)
        {
            int mid = minimumDistance + (maximumDistance - minimumDistance) / 2;
            if (IsPossible(coordinates, numberOfCows, mid))
            {
                ans = mid;
                minimumDistance = mid + 1;
            }
            else maximumDistance = mid - 1;

        }
        return ans;
    }

    private static bool IsPossible(int[] coordinates, int numberOfCows, int mid)
    {
        numberOfCows--;
        int lastCowPosition = 0;
        // keeping first cow in first stall always
        for (int i = 1; i < coordinates.Length; i++)
        {
            int diff = coordinates[i] - coordinates[lastCowPosition];
            if (diff >= mid) 
            {
                numberOfCows--;
                lastCowPosition = i;
            }
        }
        return numberOfCows <= 0;
    }
}
