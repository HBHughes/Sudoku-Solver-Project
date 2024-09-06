// See https://aka.ms/new-console-template for more information
using Sudoku_Solver.Classes;
bool Start = false;
int ProcessIdentifier = 1000;
Console.WriteLine("Input Value for Operation\n[0] Input Sudoku \n[1] Generate Sudoku");
while (Start == false) // Force User to Select A Process note: There may be a more efficient console application but I'm going to leave this until I implement this into a website.
{
    string? userinput = Console.ReadLine();
    if (UI.UserValidInput(userinput) == true)
    {
        Start = true;
        ProcessIdentifier = Convert.ToInt16(userinput);
    }
    else
    {
        Console.WriteLine("Invalid User Input, Try Again");
    }
}
if (Start == true && ProcessIdentifier == 0)
{
    Console.WriteLine("Input Valid Sudoku Grid:");
    string? k = Console.ReadLine();
    if (UI.UserValidSudokuInput(k) == true && k != null)
    {
        int[,] u = Sudoku.GridToArray(k);
        for (int row = 0; row < 9; row++) //Prints my 2d Array
        {
            for (int col = 0; col < 9; col++)
            {
                Console.Write(u[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
    else { Console.WriteLine("Invalid User Input"); }
}
