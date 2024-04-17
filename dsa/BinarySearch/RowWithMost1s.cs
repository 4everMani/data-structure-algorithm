

namespace BinarySearch;

public class RowWithMost1s
{
    // You are given a 2D matrix 'ARR' (containing either ‘0’ or ‘1’) of size 'N' x 'M', where each row is in sorted order.
    // Find the 0-based index of the first row with the maximum number of 1's.

    // Note :
    // If two rows have the same number of 1’s, return the row with a lower index.
    // If no row exists where at-least one '1' is present, return -1.

    // Example:
    // Input: ‘N’ = 3, 'M' = 3
    // 'ARR' = 
    // [   [ 1,  1,  1 ],
    //     [ 0,  0,  1 ],
    //     [ 0,  0,  0 ]   ]

    // Output: 0

    // Explanation: The 0th row of the given matrix has the maximum number of ones.

    public static void Solution(int[][] matrix)
    {
        int index = FindIndex(matrix);
        System.Console.WriteLine(index);
    }

    private static int FindIndex(int[][] matrix)
    {
        int row = -1;
        int maxCont = 0;
        for(int i = 0; i < matrix.Length; i++)
        {
            int countOfOne = GetCount(matrix[i]);
            if (countOfOne > maxCont)
            {
                row = i;
                maxCont = countOfOne;
            }
        }
        return row;
    }

    private static int GetCount(int[] nums)
    {
        int start = 0;
        int end = nums.Length - 1;
        int idx = -1;

        while (start <= end)
        {
            int mid = start + (end - start) / 2;
            if (nums[mid] == 1)
            {
                end = mid - 1;
                idx = mid;
            }
            else start = mid  + 1;
        }
        return idx == -1 ? idx : nums.Length - idx;
    }
}
