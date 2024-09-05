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
              int v = Convert.ToInt16(k);
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
    }
}
