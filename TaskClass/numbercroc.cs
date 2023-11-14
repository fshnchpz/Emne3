namespace Emne3;

public class numbercroc
{
    private static int Score = 0;
    private static Random rand = new();
    public static void Load()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("You have loaded into the task: numberCroc!");
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Fill in the blank. Acceptable input: ( < , > , = )");
        Console.ForegroundColor = ConsoleColor.White;
        StartGame();
    }

    static void StartGame()
    {
        int num1 = rand.Next(1, 11);
        int num2 = rand.Next(1, 11);
        Console.WriteLine($"{num1} _ {num2}");
        string input = Console.ReadLine();

        if (input != "<" && input != ">" && input != "=")
            Program.Main();

        if (input == "=")
        {
            if (num1 == num2)
                WinPoint();
            else
                LosePoint();
        }
        else if (input == "<")
        {
            if (num1 < num2)
                WinPoint();
            else
                LosePoint();
        }
        else if (input == ">")
        {
            if (num1 > num2)
                WinPoint();
            else
                LosePoint();
        }
    }

    static void WinPoint()
    {
        Score++;
        Console.WriteLine($"Correct! Your score: {Score}");
        StartGame();
    }

    static void LosePoint()
    {
        Score--;
        if (Score < 0)
            Score = 0;
        Console.WriteLine($"Wrong! Your score: {Score}");
        StartGame();
    }
}