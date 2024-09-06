// See https://aka.ms/new-console-template for more information
using Sudoku_Solver.Classes;
bool Start = false;
int ProcessIdentifier = 1000;
/*int[,] testsudokuBoard = {
            { 5, 3, 0, 0, 7, 0, 0, 0, 0 },
            { 6, 0, 0, 1, 9, 5, 0, 0, 0 },
            { 0, 9, 8, 0, 0, 0, 0, 6, 0 },
            { 8, 0, 0, 0, 6, 0, 0, 0, 3 },
            { 4, 0, 0, 8, 0, 3, 0, 0, 1 },
            { 7, 0, 0, 0, 2, 0, 0, 0, 6 },
            { 0, 6, 0, 0, 0, 0, 2, 8, 0 },
            { 0, 0, 0, 4, 1, 9, 0, 0, 5 },
            { 0, 0, 0, 0, 8, 0, 0, 7, 9 }};
if (Sudoku.Solve(testsudokuBoard))
{
    Console.WriteLine("Sudoku solved:");
    Sudoku.PrintBoard(testsudokuBoard);
}
else
{
    Console.WriteLine("No solution exists.");
} */
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
        if (Sudoku.Solve(u))
        {
            Console.WriteLine("Sudoku solved:");
            Sudoku.PrintBoard(u);
        }
        else
        {
            Console.WriteLine("No solution exists.");
        }
    }
    else { Console.WriteLine("Invalid User Input"); }
}
