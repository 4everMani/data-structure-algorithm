namespace BinarySearch;

public class SearchIn2DMatrixII
{

    public static void Solution(int[][] matrix, int target)
    {
        bool result = SearchMatrix(matrix, target);
        System.Console.WriteLine(result);
    }

     public static bool SearchMatrix(int[][] matrix, int target) {
        int n = matrix.Length;
        int m = matrix[0].Length;
        if (target > matrix[n - 1][m - 1] || target < matrix[0][0]) return false;

        int row = 0;
        int col = m - 1;
        while(row < n && col >= 0)
        {
            if (matrix[row][col] == target) return true;
            else if(target < matrix[row][col]) col--;
            else row++;
        }
        return false;
    }
}
