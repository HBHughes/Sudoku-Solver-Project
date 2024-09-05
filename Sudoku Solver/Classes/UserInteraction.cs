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
        public static void UserSudokuInput(string k)
        {
            // Heavily Reliant on Sudoku.GrindToArray
        }
    }
    internal class Sudoku
    {
        public static int[] SudokuGenerate()
        {
            int[] ints = [1]; // Reliant on Sudoku.SudokuSolve
            return ints;
        }
        public static int[] SudokuSolve(int[] puzzle)
        {
            return [1]; // Backtracking & Method From https://norvig.com/sudoku.html adapted to C#
        }
        public static void BlankGrid()
        {
            // Generate Blank Grid (81 0's) (String) Recursion or Constant <Recursion is Cooler>
        }
        public static void GridToArray(string k)
        {
            // 1. Check if String is Not Null and 81 Characters, 2. Splice Characters 1 at a time into an Int Array (Checking if they are valid integers)
        }
    }
}
