namespace BinarySearch;

public class SearchIn2DMatrix
{

    // You are given an m x n integer matrix matrix with the following two properties:

    // Each row is sorted in non-decreasing order.
    // The first integer of each row is greater than the last integer of the previous row.
    // Given an integer target, return true if target is in matrix or false otherwise.

    // You must write a solution in O(log(m * n)) time complexity.

    // Example 1:
    // Input: matrix = [[1,3,5,7],[10,11,16,20],[23,30,34,60]], target = 3
    // Output: true

    
    public static void Solution(int[][] matrix, int target)
    {
        bool result = SearchMatrix(matrix, target);
        System.Console.WriteLine(result);
    }

    public static bool SearchMatrix(int[][] matrix, int target) {

        if (target < matrix[0][0] || target > matrix[matrix.Length - 1][matrix[0].Length - 1]) return false;

       int start = 0;
       int end = matrix.Length - 1;
       while (start <= end)
       {
        int mid = start + (end - start) / 2;
        if (matrix[mid][0] == target) return true;
        else if (matrix[mid][0] > target) end = mid - 1;
        else start = mid + 1;
       }
       return IsTargetFound(matrix[end], target);
    }

    private static bool IsTargetFound(int[] nums, int target)
    {
        int start = 0;
        int end = nums.Length - 1;

        while (start <= end)
        {
            int mid = start + (end - start) / 2;
            if (nums[mid] == target) return true;
            else if (nums[mid] > target) end = mid - 1;
            else if (nums[mid] < target) start = mid + 1;
        }
        return false;
    }

}
