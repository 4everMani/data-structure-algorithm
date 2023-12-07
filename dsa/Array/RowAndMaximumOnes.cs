using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Array
{
    public class RowAndMaximumOnes
    {


        //Given a m x n binary matrix mat, find the 0-indexed position of the row that contains the maximum count of ones, and the number of ones in that row.

        //In case there are multiple rows that have the maximum count of ones, the row with the smallest row number should be selected.

        //Return an array containing the index of the row, and the number of ones in it.
        //Input: mat = [[0,0],[1,1],[0,0]]
        //Output: [1,2]
        //Explanation: The row indexed 1 has the maximum count of ones(2). So the answer is [1,2].
        public static int[] Solution(int[][] mat)
        {
            var index = 0;
            var finalCount = 0;

            for (int i = 0; i < mat.Length; i++)
            {
                var count = 0;

                for (int j = 0; j < mat[i].Length; j++)
                {
                    if (mat[i][j] == 1)
                    {
                        count += 1;
                    }
                }

                if (count > finalCount)
                {
                    finalCount = count;
                    index = i;
                }
            }
            return new int[] { index, finalCount };
        }
    }
}
