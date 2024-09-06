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
              if (v==0 || v==1)
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
            var search = @"^-?[0-9]+(?:\.[0-9]+)?$";
            var regex = new Regex(search);
            return regex.IsMatch(k);
        }   
    }
    internal class Sudoku
    {
        public static void SudokuGenerate()
        {
            // Reliant on Sudoku.SudokuSolve Randomizing a Solution from a Blank Grid, then removing random squares || possibility for difficulties later ie remove x squares = easy
        }
        public static int[] SudokuSolve(int[] puzzle)
        {
            return [1]; // Backtracking & Method From https://norvig.com/sudoku.html adapted to C#
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
