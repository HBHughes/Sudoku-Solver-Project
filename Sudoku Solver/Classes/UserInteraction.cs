using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Sudoku_Solver.Classes
{
    internal class UI
    {
        public static bool UserValidInput(string? k) 
        {
            try
            {
              int v = Convert.ToInt32(k);
              if (v==0)
                {
                    return true;
                }
              else
                {
                    return false;
                }
            }
            catch {return false;}
        }
        public static bool UserValidSudokuInput(string? k)
        {
            if (k != null && k.Length == 81 && AllCharAreInt(k)) // Checks if String is Not Null and is 81 Characters
            {
                return true;
            }
            // 2. Return True/False -> True: Transfer to GridToArray False: Invalid Input
            else { return false; }
        }
        public static bool AllCharAreInt(string k)
        {
            var search = @"^-?[0-9]+(?:\.[0-9]+)?$"; //Regular Expression Checking if all Characters are Integers
            var regex = new Regex(search);
            return regex.IsMatch(k);
        }   
    }
    internal class Sudoku
    {
        public static bool Solve(int[,] board)
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (board[row, col] == 0) // Find an empty cell
                    {
                        for (int num = 1; num <= 9; num++) // Try possible numbers
                        {
                            if (IsValidNum(board, row, col, num))
                            {
                                board[row, col] = num; // Place the number
                                if (Solve(board)) // Recursively attempt to solve
                                {
                                    return true;
                                }
                                board[row, col] = 0; // Reset if not solved
                            }
                        }
                        return false; // Return false if no number is valid
                    }
                }
            }
            return true; // Solution found
        }
        private static bool IsValidNum(int[,] board, int row, int col, int num)
        {
            // Check if num is not in the current row
            for (int c = 0; c < 9; c++)
            {
                if (board[row, c] == num)
                {
                    return false;
                }
            }

            // Check if num is not in the current column
            for (int r = 0; r < 9; r++)
            {
                if (board[r, col] == num)
                {
                    return false;
                }
            }

            // Check if num is not in the 3x3 sub-grid
            int startRow = row - row % 3;
            int startCol = col - col % 3;
            for (int r = startRow; r < startRow + 3; r++)
            {
                for (int c = startCol; c < startCol + 3; c++)
                {
                    if (board[r, c] == num)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static void SudokuGenerate()
        {
            // Leaving out for now can implement if bored
        }
        public static string BlankGrid()
        {
            string k = "000000000000000000000000000000000000000000000000000000000000000000000000000000000";
            return k;
            // Generates Blank Grid (81 0's) (String)
        }
        public static int[,] GridToArray(string k)
        {
            int[,] result = new int[9, 9];

            for (int i = 0; i < 81; i++)
            {
                // Calculate the row and column indices
                int row = i / 9;
                int col = i % 9;

                // Convert character to integer and assign to the result array
                result[row, col] = k[i] - '0';
            }

            return result;
        }
        public static void PrintBoard(int[,] board)
        {
            int Sizerow = board.GetLength(0); //im adding this incase I want to add grids with other sizes (might not be possible need to work on algorithm)
            int Sizecol = board.GetLength(1); 
            for (int i = 0; i < Sizerow; i++)
            {
                for (int j = 0; j < Sizecol; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
