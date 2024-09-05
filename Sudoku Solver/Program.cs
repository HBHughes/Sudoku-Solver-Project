// See https://aka.ms/new-console-template for more information
using Sudoku_Solver.Classes;
bool Start = false;
int ProcessIdentifier = 100;
Console.WriteLine("Input Value for Operation\n[0] Input Sudoku \n[1] Generate Sudoku");
while (Start == false) // Force User to Select A Process
{
    var userinput = Console.ReadLine();
    if (userinput != null) 
    { bool v = UI.UserValidInput(userinput); 
        if (v==true)
        {
            Start = true;
            ProcessIdentifier = Convert.ToInt16(userinput);
        }
        else
        {
            Console.WriteLine("Invalid User Input, Try Again");
        }
    }
}
if (Start == true && ProcessIdentifier == 0)
{
    Console.WriteLine(ProcessIdentifier);
}
