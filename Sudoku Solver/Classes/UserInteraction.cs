using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_Solver.Classes
{
    internal class UI
    {
        public static bool UserValidInput(string k) 
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
        public static void UserValidSudokuInput(string k)
        {
            // 1. Check if String is Not Null and is 81 Characters and all Valid Integers
            // 2. Return True/False -> True: Transfer to GridToArray False: Invalid Input
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
        public static void GridToArray(string k)
        {
            for (int i = 0; i < k.Length; i++)
            {
                // Splicing 1 Character at a time
            }
            // Return Array
        }
    }
}
