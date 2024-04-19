

namespace BinarySearch;

public class FindPeakElementII
{
    // A peak element in a 2D grid is an element that is strictly greater than all of its adjacent neighbors to the left, right, top, and bottom.
    // Given a 0-indexed m x n matrix mat where no two adjacent cells are equal, find any peak element mat[i][j] and return the length 2 array [i,j].
    // You may assume that the entire matrix is surrounded by an outer perimeter with the value -1 in each cell.
    // You must write an algorithm that runs in O(m log(n)) or O(n log(m)) time.

    // Input: mat = [[1,4],[3,2]]
    // Output: [0,1]
    // Explanation: Both 3 and 4 are peak elements so [1,0] and [0,1] are both acceptable answers.

    public static void Solution(int[][] matrix)
    {
        int[] result = Optimal(matrix);
        // System.Console.WriteLine(result.Join(",").ToString());
    }

    private static int[] Bruteforce(int[][] matrix)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                if (IsPeakElement(matrix, i , j))
                {
                    return [i, j];
                }
            }
        }
        return [0 ,0];
    }

    private static bool IsPeakElement(int[][] matrix, int i , int j)
    {
        int top = i - 1 < 0 ? -1 : matrix[i - 1][j];
        int bottom = i + 1 >= matrix.Length ? -1 : matrix[i + 1][j];
        int left = j - 1 < 0 ? -1 : matrix[i][j - 1];
        int right = j + 1 >= matrix[0].Length ? -1 : matrix[i][j + 1];
        return matrix[i][j] > top && matrix[i][j] > bottom && matrix[i][j] > right && matrix[i][j] > left;
    }


    public static int[] Optimal(int[][] matrix) {
        int start = 0;
        int end = matrix[0].Length - 1;

        while (start <= end) 
        {
            int mid = start + (end - start) / 2;
            int peakRow = FindPeakRow(matrix, mid);
            if (IsPeakElement(matrix, peakRow, mid))
            {
                return [peakRow,mid];
            }
            else if (mid - 1 >= start && matrix[peakRow][mid] < matrix[peakRow][mid - 1])
            {
                end = mid - 1;
            }
            else start = mid + 1;
        }
        return [-1 ,-1];
    }

    private static int FindPeakRow(int[][] matrix, int mid)
    {
        int idx = -1;
        int maxValue = int.MinValue;
        for (int i = 0; i < matrix.Length; i++)
        {
            if (matrix[i][mid] > maxValue)
            {
                maxValue = matrix[i][mid];
                idx = i;
            }
        }
        return idx;
    }

    private static int FindPeakElement(int[][] matrix, int[] nums, int i)
    {
        if (nums[0] > nums[1])
        {
            if (IsPeakElement(matrix, i, 0)) return 0;
        }
        if (nums[^1] > nums[^2] && IsPeakElement(matrix, i, matrix[i].Length - 1))
        {
            return matrix[i].Length - 1;
        }
        else
        {
            int start = 1;
            int end = nums.Length - 2;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (IsPeakElement(matrix, i, mid))
                {
                    return mid;
                }
                else if (nums[mid] < nums[mid + 1] && nums[mid] < nums[mid - 1])
                {
                    int leftDiff = nums[mid - 1] - nums[mid];
                    int rightDiff = nums[mid + 1] - nums[mid];
                    _ = leftDiff > rightDiff ? end = mid - 1 : start = mid + 1;
                }
                else if (nums[mid] < nums[mid + 1])
                {
                    start = mid + 1;
                }
                else end = mid - 1;
            }
        }
        return -1;   
    }

}
