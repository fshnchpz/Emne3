namespace Emne3;

public class switchCase
{
    public static void Load()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("You have loaded into the task: switchCase!");
        Console.WriteLine("---------------------------------------");
        Console.ForegroundColor = ConsoleColor.White;

        Task1();
    }

    static void Task1()
    {
        int day = 3;
        string DayName = day switch
        {
            1 => "Monday",
            2 => "Tuesday",
            3 => "Wednesday",
            4 => "Thursday",
            5 => "Friday",
            6 => "Saturday",
            7 => "Sunday",
            _ => "nani!",
        };

        Console.WriteLine("Task 1 - What day is it?");
        Console.WriteLine("---------------------------------------");
        Console.WriteLine($"{day} is {DayName} ");
        Console.WriteLine("--------------------------------------- \n");
        Console.ReadKey();

        Task2();
    }

    static void Task2()
    {
        Console.WriteLine("Task 2 - What day is it?");
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Write a number");
        int inputDay = Convert.ToInt32(Console.ReadLine());

        string dayString = "";

        switch (inputDay)
        {
            case 1:
                dayString = "Monday";
                break;
            case 2:
                dayString = "Monday";
                break;
            case 3:
                dayString = "Monday";
                break;
            case 4:
                dayString = "Monday";
                break;
            case 5:
                dayString = "Monday";
                break;
            case 6:
                dayString = "Monday";
                break;
            case 7:
                dayString = "Monday";
                break;
            default:
            {
                Task2();
                break;
            }
        }

        Console.WriteLine($"{inputDay} is {dayString} ");
        Console.WriteLine("--------------------------------------- \n");
        Console.WriteLine("Press a button to go back to task list ... \n");
        Console.ReadKey();
        Program.Main();
    }

}