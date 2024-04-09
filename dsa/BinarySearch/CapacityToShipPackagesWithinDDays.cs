namespace BinarySearch;

public class CapacityToShipPackagesWithinDDays
{
    // A conveyor belt has packages that must be shipped from one port to another within days days.

    // The ith package on the conveyor belt has a weight of weights[i]. Each day, we load the ship 
    // with packages on the conveyor belt (in the order given by weights). We may not load more weight than the maximum weight capacity of the ship.
    // Return the least weight capacity of the ship that will result in all the packages on the conveyor belt being shipped within days days.

    // Example 1:
    // Input: weights = [1,2,3,4,5,6,7,8,9,10], days = 5
    // Output: 15
    // Explanation: A ship capacity of 15 is the minimum to ship all the packages in 5 days like this:
    // 1st day: 1, 2, 3, 4, 5
    // 2nd day: 6, 7
    // 3rd day: 8
    // 4th day: 9
    // 5th day: 10

    // Note that the cargo must be shipped in the order given, so using a ship of capacity 14 and splitting the packages into parts like (2, 3, 4, 5), (1, 6, 7), (8), (9), (10) is not allowed.
    
    // Example 2:
    // Input: weights = [3,2,2,4,1,4], days = 3
    // Output: 6
    // Explanation: A ship capacity of 6 is the minimum to ship all the packages in 3 days like this:
    // 1st day: 3, 2
    // 2nd day: 2, 4
    // 3rd day: 1, 4
    
    // Example 3:
    // Input: weights = [1,2,3,1,1], days = 4
    // Output: 3
    // Explanation:
    // 1st day: 1
    // 2nd day: 2
    // 3rd day: 3
    // 4th day: 1, 1

    public static void Solution(int[] weights, int days)
    {
        int weight = ShipWithinDays(weights, days);
        System.Console.WriteLine(weight);
    }

    private static int ShipWithinDays(int[] weights, int days) {
        int minWeight = weights.Max();
        int maxWeight =  weights.Sum();
        int minDays = -1;

        while (minWeight <= maxWeight)
        {
            int mid = minWeight + (maxWeight - minWeight) / 2;
            if (IsShippingPossible(weights, days, mid))
            {
                minDays = mid;
                maxWeight = mid - 1;
            }
            else minWeight = mid + 1;
        }
        return minDays;
    }

    private static bool IsShippingPossible(int[] weights, int days, int mid)
    {
        int weight = 0;
        int daysTaken = 1;
        for (int i = 0; i < weights.Length; i++)
        {
            if (weight + weights[i] > mid)
            {
                daysTaken++;
                weight = weights[i];
            }
            else weight += weights[i];
        }
        return daysTaken <= days;
    }
}
