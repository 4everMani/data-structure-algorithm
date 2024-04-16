
namespace BinarySearch;

public class MedianOfTwoSortedArrays
{
    // Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
    // The overall run time complexity should be O(log (m+n)).

    // Example 1:
    // Input: nums1 = [1,3], nums2 = [2]
    // Output: 2.00000
    // Explanation: merged array = [1,2,3] and median is 2.
    
    // Example 2:
    // Input: nums1 = [1,2], nums2 = [3,4]
    // Output: 2.50000
    // Explanation: merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.

    public static void Solution(int[] nums1, int[] nums2)
    {
        // double result = NaiveSolution(nums1, nums2);
         double result = BetterSolution(nums1, nums2);
        System.Console.WriteLine(result);
    }

    // Time: O(n + m)
    // Space: O(n + m)
    private static double NaiveSolution(int[] nums1, int[] nums2)
    {
        List<int> merged = new();
        int l1 = 0;
        int l2 = 0;

        while (l1 < nums1.Length && l2 < nums2.Length)
        {
            if (nums1[l1] <= nums2[l2])
            {
                merged.Add(nums1[l1]);
                l1++;
            }
            else
            {
                merged.Add(nums2[l2]);
                l2++;
            }
        }

        if (l1 < nums1.Length)
        {
            while (l1 < nums1.Length)
            {
                merged.Add(nums1[l1]);
                l1++;
            }
        }

        else if (l2 < nums2.Length)
        {
            while (l2 < nums2.Length)
            {
                merged.Add(nums2[l2]);
                l2++;
            }
        }

        if (merged.Count % 2 == 0)
        {
            var medianIndex = merged.Count / 2;
            return (double)(merged[medianIndex] + merged[medianIndex - 1]) / 2;
        }
        else
        {
            return (double)merged[(merged.Count / 2)];
        }
    }


    // Time: O (n + m)
    // Space: O(1)
    public static double BetterSolution(int[] nums1, int[] nums2) {
       var totalCount = nums1.Length + nums2.Length;
       var idx1 = totalCount / 2;
       var idx2 = idx1 - 1;
       var l1 = 0;
       var l2 = 0;       
       var m1 = -1;
       var m2 = -1;
       int count = 0;
       while (l1 < nums1.Length && l2 < nums2.Length)
       {
            if (nums1[l1] < nums2[l2])
            {
                if (count == idx1) m1 = nums1[l1];
                else if (count == idx2) m2 = nums1[l1];
                l1++;
                count++;
            }
            else
            {
                if (count == idx1) m1 = nums2[l2];
                else if (count == idx2) m2 = nums2[l2];
                l2++;
                count++;
            }
       }
       if (l1 < nums1.Length)
       {
        while (l1 < nums1.Length)
        {
            if (count == idx1) m1 = nums1[l1];
            else if (count == idx2) m2 = nums1[l1];
            l1++;
            count++;
        }
       }
       else if (l2 < nums2.Length)
       {
            while (l2 < nums2.Length)
            {
                if (count == idx1) m1 = nums2[l2];
                else if (count == idx2) m2 = nums2[l2];
                l2++;
                count++;
            }
       }
       if (totalCount % 2 == 0) return (double)(m1 + m2) / 2;
       else return m1;
    }

    private static double OptimalSolution(int[] a, int[] b)
    {
        int n1 = a.Length, n2 = b.Length;
        //if n1 is bigger swap the arrays:
        if (n1 > n2) return OptimalSolution(b, a);

        int n = n1 + n2; //total length
        int left = (n1 + n2 + 1) / 2; //length of left half
        //apply binary search:
        int low = 0, high = n1;
        while (low <= high) {
            int mid1 = (low + high) / 2;
            int mid2 = left - mid1;
            //calculate l1, l2, r1 and r2;
            int l1 = (mid1 > 0) ? a[mid1 - 1] : int.MinValue;
            int l2 = (mid2 > 0) ? b[mid2 - 1] : int.MinValue;
            int r1 = (mid1 < n1) ? a[mid1] : int.MaxValue;
            int r2 = (mid2 < n2) ? b[mid2] : int.MaxValue;

            if (l1 <= r2 && l2 <= r1) {
                if (n % 2 == 1) return Math.Max(l1, l2);
                else return ((double) (Math.Max(l1, l2) + Math.Min(r1, r2))) / 2.0;
            } else if (l1 > r2) high = mid1 - 1;
            else low = mid1 + 1;
        }
        return 0; 
    }
}
