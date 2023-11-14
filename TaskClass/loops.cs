namespace Emne3;

public class loops
{
    public static void Load()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("You have loaded into the task: loops!");
        Console.WriteLine("---------------------------------------");
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine("Task 1 - for loop");
        Console.WriteLine("---------------------------------------");
        Task1();
        Console.WriteLine("--------------------------------------- \n");
        Console.WriteLine("Press a button to continue to next task ... \n");
        Console.ReadKey();

        Console.WriteLine("Task 2 - foreach loop");
        Console.WriteLine("---------------------------------------");
        Task2();
        Console.WriteLine("--------------------------------------- \n");
        Console.WriteLine("Press a button to continue to next task ... \n");
        Console.ReadKey();

        Console.WriteLine("Task 3 - while loop");
        Console.WriteLine("---------------------------------------");
        Task3();
        Console.WriteLine("--------------------------------------- \n");
        Console.WriteLine("Press a button to go back to task list ... \n");
        Console.ReadKey();
        Program.Main();
    }

    static void Task1()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Terje er kul");
        }
    }
    static void Task2()
    {
        string myString = "Terje";
        Console.WriteLine("String to do foreach loop on and print each character: Terje");
        foreach (char letter in myString)
        {
            Console.WriteLine(letter);
        }
    }
    static void Task3()
    {
        int Runde = 1;
        while (Runde < 10)
        {
            Console.WriteLine($"Runde nr {Runde}");
            Runde++;
        }
    }
}