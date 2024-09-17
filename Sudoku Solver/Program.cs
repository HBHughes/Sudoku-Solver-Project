using Sudoku_Solver.Classes;
bool Start = false;
int ProcessIdentifier = 1000;
Console.WriteLine("Input Value for Operation\n[0] Input Sudoku\n[1] Generate Sudoku\n[2] Generate and Solve\n[3] Time Test\n[4] Repetition Test");
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
if (Start == true)
{
    if (ProcessIdentifier == 0)
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
    if (ProcessIdentifier == 1)
    {
        Sudoku generator = new Sudoku();
        int[,] board = generator.GetBoard();
        Sudoku.PrintBoard(board);
    }
    if (ProcessIdentifier == 2)
    {
        Sudoku generator = new Sudoku();
        int[,] board = generator.GetBoard();
        Sudoku.PrintBoard(board);
        Console.WriteLine("\n");
        Sudoku.Solve(board);
        Sudoku.PrintBoard(board);
    }
    if (ProcessIdentifier == 3)
    {
        var watch = System.Diagnostics.Stopwatch.StartNew();
        Sudoku generator = new Sudoku();
        int[,] board = generator.GetBoard();
        Sudoku.PrintBoard(board);
        Console.WriteLine("\n");
        Sudoku.Solve(board);
        Sudoku.PrintBoard(board);
        watch.Stop();
        long elapsedMs = watch.ElapsedMilliseconds;
        Console.WriteLine(elapsedMs);
    }
    if (ProcessIdentifier == 4)
    {
        int repetitions = 1000;
        double totalms = 0;
        for (int i = 0; i < repetitions; i++) {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            Sudoku generator = new Sudoku();
            int[,] board = generator.GetBoard();
            Sudoku.PrintBoard(board);
            Console.WriteLine("\n");
            Sudoku.Solve(board);
            Sudoku.PrintBoard(board);
            watch.Stop();
            long elapsedMs = watch.ElapsedMilliseconds;
            totalms = totalms + Convert.ToDouble(elapsedMs);
        }
        Console.WriteLine(totalms / Convert.ToDouble(repetitions));
    }
}