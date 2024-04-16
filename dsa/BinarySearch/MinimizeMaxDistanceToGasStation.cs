
using System.Globalization;

namespace BinarySearch;

public class MinimizeMaxDistanceToGasStation
{
    // You are given a sorted array ‘arr’ of length ‘n’, which contains positive integer positions of ‘n’ gas stations on the X-axis.
    // You are also given an integer ‘k’.
    // You have to place 'k' new gas stations on the X-axis.
    // You can place them anywhere on the non-negative side of the X-axis, even on non-integer positions.
    // Let 'dist' be the maximum value of the distance between adjacent gas stations after adding 'k' new gas stations.
    // Find the minimum value of dist.

    // Example:
    // Input: ‘n' = 7 , ‘k’=6, ‘arr’ = {1,2,3,4,5,6,7}.
    // Answer: 0.5

    // Explanation:
    // We can place 6 gas stations at 1.5, 2.5, 3.5, 4.5, 5.5, 6.5. 
    // Thus the value of 'dist' will be 0.5. It can be shown that we can't get a lower value of 'dist' by placing 6 gas stations.

    public static void Solution(int[] arr, int k)
    {
        double result = NaiveSolution(arr,  k);
        System.Console.WriteLine(result);
    }

    private static double NaiveSolution(int[] arr, int k)
    {
        int[] partition = new int[arr.Length - 1];
        List<int> howMany = new List<int>(arr.Length - 1);
        

        for (int gasStation = 1; gasStation <= k; gasStation++)
        {
            double maxLength = -1;
            int maxIndex = -1;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int diff = arr[i + 1] - arr[i];
                double sectionLength = (double)(diff / (partition[i] + 1));
                if (sectionLength > maxLength)
                {
                    maxLength = sectionLength;
                    maxIndex = i;
                }
            }
            partition[maxIndex] += 1;
        }
        double maxDistance = double.MinValue;
        for (int j = 0; j < arr.Length - 1; j++)
        {
            double distance = (double)(arr[j + 1] - arr[j]) / (partition[j] + 1);
            if (distance > maxDistance) maxDistance = distance;
        }
        return maxDistance;
    }

    private static double OptimalSolution(int[] arr, int k)
    {
        int[] partition = new int[arr.Length - 1];
        KeyValuePair<int, double> a = new();
        // PriorityQueue<KeyValuePair<int, double>> queue = new();
        

        for (int gasStation = 1; gasStation <= k; gasStation++)
        {
            double maxLength = -1;
            int maxIndex = -1;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int diff = arr[i + 1] - arr[i];
                double sectionLength = (double)(diff / (partition[i] + 1));
                if (sectionLength > maxLength)
                {
                    maxLength = sectionLength;
                    maxIndex = i;
                }
            }
            partition[maxIndex] += 1;
        }
        double maxDistance = double.MinValue;
        for (int j = 0; j < arr.Length - 1; j++)
        {
            double distance = (double)(arr[j + 1] - arr[j]) / (partition[j] + 1);
            if (distance > maxDistance) maxDistance = distance;
        }
        return maxDistance;
    }
}
