


namespace Backtracking;

public class SudokuSolver
{
    // Write a program to solve a Sudoku puzzle by filling the empty cells.

    // A sudoku solution must satisfy all of the following rules:

    // Each of the digits 1-9 must occur exactly once in each row.
    // Each of the digits 1-9 must occur exactly once in each column.
    // Each of the digits 1-9 must occur exactly once in each of the 9 3x3 sub-boxes of the grid.
    // The '.' character indicates empty cells.

    // Example 1:


    // Input: board = [["5","3",".",".","7",".",".",".","."],["6",".",".","1","9","5",".",".","."],[".","9","8",".",".",".",".","6","."],["8",".",".",".","6",".",".",".","3"],["4",".",".","8",".","3",".",".","1"],["7",".",".",".","2",".",".",".","6"],[".","6",".",".",".",".","2","8","."],[".",".",".","4","1","9",".",".","5"],[".",".",".",".","8",".",".","7","9"]]
    // Output: [["5","3","4","6","7","8","9","1","2"],["6","7","2","1","9","5","3","4","8"],["1","9","8","3","4","2","5","6","7"],["8","5","9","7","6","1","4","2","3"],["4","2","6","8","5","3","7","9","1"],["7","1","3","9","2","4","8","5","6"],["9","6","1","5","3","7","2","8","4"],["2","8","7","4","1","9","6","3","5"],["3","4","5","2","8","6","1","7","9"]]

    public static void Solution(char[][] board)
    {
        SudokuSol(board);
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                Console.Write(board[i][j] + " ");
            }
            System.Console.WriteLine();
        }
    }

    private static void SudokuSol(char[][] board)
    {
        Helper(board);
    }

    // return type is bool coz when we do not found any solution for a block we need to backtrack
    private static bool Helper(char[][] board)
    {
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[0].Length; j++)
            {
                if (board[i][j] == '.') 
                {
                    for (char k = '1'; k <= '9'; k++)
                    {
                        if (IsValid(board, i, j, k))
                        {
                            board[i][j] = k;
                            // If solutin found
                            // return ture
                            // else backtrack
                            if (Helper(board)) return true;
                            board[i][j] = '.';
                        }
                    }
                    // when no valid solution found for a block, return false;
                    return false;
                }
            }
        }
        return true;
    }

    private static bool IsValid(char[][] board, int row, int col, char k)
    {
        // Checking row and column
        for (int i = 0; i < board[0].Length; i++)
        {
            if (board[row][i] == k) return false;
            else if (board[i][col] == k) return false;  
            else if (board[3*(row / 3) + (i / 3)][3*(col / 3) + (i % 3)] == k) return false;
        }

        // Checking square
        // (int startRow, int endRow, int startCol, int endCol) = FindSquare(row, col);

        // while (startRow <= endRow)
        // {
        //     for (int cc = startCol; cc <= endCol; cc++)
        //     {
        //         if (board[startRow][cc] == (char) k) return false;
        //     }
        //     startRow++;
        // }
        return true;
    }

    private static (int, int, int, int) FindSquare(int row, int col)
    {
        int sr = 0;
        int er = 0;
        int sc = 0;
        int ec = 0;

        if (row >= 0 && row <= 2)
        {
            sr = 0;
            er = 2;
        } 
        else if (row >= 3 && row <= 5)
        {
            sr = 3;
            er = 5;
        } 
        else
        {
            sr = 6;
            er = 8;
        } 

        if (col >= 0 && col <= 2)
        {
            sc = 0;
            ec = 2;
        }
        else if (col >= 3 && col <= 5)
        {
            sc = 3;
            ec = 5;
        }
        else
        {
            sc = 6;
            ec = 8;
        } 

        return (sr, er, sc, ec);

    }
}
