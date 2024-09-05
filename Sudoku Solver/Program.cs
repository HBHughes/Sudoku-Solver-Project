// See https://aka.ms/new-console-template for more information
using Sudoku_Solver.Classes;
bool Start = false;
int ProcessIdentifier = 100;
Console.WriteLine("Input Value for Operation\n[0] Input Sudoku \n[1] Generate Sudoku");
while (Start == false) // Force
{
    var userinput = Console.ReadLine();
    if (userinput != null) 
    { bool v = UI.UserValidInput(userinput); 
        if (v==true)
        {
            Start = true;
        }
        else
        {
            Console.WriteLine("Invalid User Input: Please Input [0] or [1]");  
        }
    }
}
if (Start == true)
{
    Console.WriteLine("Start = True");
}
