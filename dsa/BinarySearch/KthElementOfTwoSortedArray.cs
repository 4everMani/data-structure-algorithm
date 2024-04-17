
using System.Security.Cryptography;

namespace BinarySearch;

public class KthElementOfTwoSortedArray
{
    // You're given two sorted arrays 'arr1' and 'arr2' of size 'n' and 'm' respectively and an element 'k'
    // Find the element that would be at the 'kth' position of the combined sorted array.
    // Position 'k' is given according to 1 - based indexing, but arrays 'arr1' and 'arr2' are using 0 - based indexing.

    // For example :
    // Input: 'arr1' = [2, 3, 45], 'arr2' = [4, 6, 7, 8] and 'k' = 4
    // Output: 6
    // Explanation: The merged array will be [2, 3, 4, 6, 7, 8, 45]. The element at position '4' of this array is 6. Hence we return 6.

    public static void Solution(int[] nums1, int[] nums2, int k)
    {
        int result = OptimalSolution(nums1, nums2, k);
        System.Console.WriteLine(result);
    }

    private static int OptimalSolution(int[] nums1, int[] nums2, int k)
    {
        int n = nums1.Length;
        int m = nums2.Length;
        if (n > m) return OptimalSolution(nums2, nums1, k);
        int start = Math.Max(0, k -  m);
        int end = Math.Min(n, k);

        while (start <= end)
        {
            int mid1 = start + (end - start) / 2;
            int mid2 = k - mid1;
            int l1 = mid1 > 0 ? nums1[mid1 - 1]: int.MinValue;
            int l2 = mid2 > 0 ? nums2[mid2 - 1] : int.MinValue;
            int r1 = mid1 < n ? nums1[mid1] : int.MaxValue;
            int r2 = mid2 < m ? nums2[mid2] : int.MaxValue;

            if (l1 <= r2 && l2 <= r1)
            {
                return Math.Max(l1, l2);
            }
            else if (l1 > r2) end = mid1 - 1;
            else start = mid1 + 1;
        }
        return 0;
    }
}
