// See https://aka.ms/new-console-template for more information
using Sudoku_Solver.Classes;
bool Start = false;
Console.WriteLine("Input Value for Operation\n[0] Input Sudoku \n[1] Generate Sudoku");
while (Start == false)
{
    var userinput = Console.ReadLine();
    if (userinput != null) 
    { bool v = Classes.UserValidInput(userinput); 
        if (v==true)
        {
            Start = true;
        }
        else
        {
            Console.WriteLine("No");  
        }
    }
}
