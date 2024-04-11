
namespace BinarySearch;

public class KthMissingPositiveNumber
{
    // Given an array arr of positive integers sorted in a strictly increasing order, and an integer k.
    // Return the kth positive integer that is missing from this array.

    // Example 1:
    // Input: arr = [2,3,4,7,11], k = 5
    // Output: 9
    // Explanation: The missing positive integers are [1,5,6,8,9,10,12,13,...]. The 5th missing positive integer is 9.
    
    // Example 2:
    // Input: arr = [1,2,3,4], k = 2
    // Output: 6
    // Explanation: The missing positive integers are [5,6,7,...]. The 2nd missing positive integer is 6.

    public static void Solution(int[] arr, int k)
    {
        int result = BruteForceMethod(arr, k);
        System.Console.WriteLine(result);
    }

    private static int BruteForceMethod(int[] arr, int k)
    {
        var set = new HashSet<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            set.Add(arr[i]);
        }
        int val = 1;
        while (true)
        {
            if (!set.Contains(val))
            {
                k--;
                if (k == 0) return val;
            }
            val++;
        }
    }

    private static int BetterSolution(int[] arr, int k)
    {
        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] <= k) k++; //shifting k
            else break;
        }
        return k;
    }

    public static int OptimalSolution(int[] arr, int k)
    {
        int start = 0;
        int end = arr.Length - 1;

        while(start <= end)
        {
            int mid = start + (end - start) / 2;
            if (arr[mid] - (mid + 1) >= k)
            {
                end = mid - 1;
            }
            else start = mid + 1;
        }
        return end + 1 + k;
    }
}
