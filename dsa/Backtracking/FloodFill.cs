using System.Numerics;
using System.Runtime.Intrinsics.Arm;

namespace Backtracking;

public class FloodFill
{
    public static void Solution(int [][] matrix, int s, int s2, int target )
    {
        int source = matrix[s][s2];

        var output = FloodFillSol( matrix, s, s2, target, source );

        foreach ( var row in output )
        {
            foreach ( var item in row )
            {
                Console.Write( item );
            }
            System.Console.WriteLine( );
        }

    }

    private static int[][] FloodFillSol(int[][] matrix, int s, int s2, int target, int source)
    {
        if (s < matrix.Length && s >= 0 && s2 < matrix.Length && s2 >= 0 && matrix[s][s2] == source)
        {
            matrix[s][s2] = target;
            FloodFillSol(matrix, s - 1, s2, target, source);
            FloodFillSol(matrix, s + 1, s2, target, source);
            FloodFillSol(matrix, s, s2 + 1, target, source);
            FloodFillSol(matrix, s, s2 - 1, target, source);
        }
        return matrix;
    }
}
