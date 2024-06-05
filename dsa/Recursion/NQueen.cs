using System.Runtime.CompilerServices;
using System.Text;

namespace Recursion;


// The n-queens puzzle is the problem of placing n queens on an n x n chessboard 
// such that no two queens attack each other.
// Given an integer n, return all distinct solutions to the n-queens puzzle. 
// You may return the answer in any order. 
// Each solution contains a distinct board configuration of the n-queens' 
// placement, where 'Q' and '.' both indicate a queen and an empty space, respectively.

// Input: n = 4
// Output: [[".Q..","...Q","Q...","..Q."],["..Q.","Q...","...Q",".Q.."]]
// Explanation: There exist two distinct solutions to the 4-queens puzzle as shown above
// Example 2:

// Input: n = 1
// Output: [["Q"]]

public class NQueen
{
    public static void Solution(int n)
    {
        SolveNQueens(n);
    }

    public static IList<IList<string>> SolveNQueens(int n) {
        IList<IList<string>> result = [];
        List<string> board = [];
        string temp = new('.', n);
        for (int i = 1; i <= n; i++)
        {
            board.Add(temp);
        }
        Helper(n, result, board, 0);
        return result;
    }

    private static void Helper(int n, IList<IList<string>> result, List<string> board, int col)
    {
        if (col == n)
        {
            result.Add(new List<string>(board));
            return;
        }
        for (int row = 0; row < n; row++)
        {
            if (ValidConfig(board, row, col, n))
            {
                var str = new StringBuilder(board[row]);
                str[col] = 'Q';
                board[row] = str.ToString();

                Helper(n, result, board, col + 1);
                
                // backtracking
                var rowString = new StringBuilder(board[row]);
                rowString[col] = '.';
                board[row] = rowString.ToString();
            }
        }
    }

    private static bool ValidConfig(List<string> board, int row, int col, int n)
    {
        // check left horizontal
        for (int c = col - 1; c >= 0; c--)
        {
            if (board[row][c] == 'Q') return false;
        }

        // check left diagonally
        for (int r = row - 1, c = col - 1 ; r >=0 && c >= 0 ; r--, c--)
        {
            if (board[r][c] == 'Q') return false;
        }

        for (int r = row + 1, c = col - 1; c >=0 && r < n; c--, r++)
        {
            if (board[r][c] == 'Q') return false;
        }

        return true;
    }
}
