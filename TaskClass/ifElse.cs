namespace Emne3
{
    public class ifElse
    {
        //Model


        //View
        public static void Load()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("You have loaded into the task: ifElse!");
            Console.WriteLine("---------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;

            int Number1 = 2;
            int Number2 = 2;

            Console.WriteLine("Task 1 - Check if Equal");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Write 2 numbers:");
            Number1 = Convert.ToInt32(Console.ReadLine());
            Number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Number 1: {Number1} (int)");
            Console.WriteLine($"Number 2: {Number2} (int)");
            Console.WriteLine("Are these numbers equal?");
            Console.WriteLine($"Returned (bool): {Task1(Number1,Number2)}");
            Console.WriteLine("--------------------------------------- \n");
            Console.ReadKey();

            Console.WriteLine("Task 2 - Multiply or add (true/false)");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Write 2 numbers:");
            Number1 = Convert.ToInt32(Console.ReadLine());
            Number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Number 1: {Number1} (int)");
            Console.WriteLine($"Number 2: {Number2} (int)");
            Console.WriteLine("Multiply or add if equal");
            Console.WriteLine($"Returned (int): {Task2(Number1, Number2)}");
            Console.WriteLine("--------------------------------------- \n");
            Console.ReadKey();

            Console.WriteLine("Task 3 - Are one of the numbers 30? or totaled to 30?");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Write 2 numbers:");
            Number1 = Convert.ToInt32(Console.ReadLine());
            Number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Number 1: {Number1} (int)");
            Console.WriteLine($"Number 2: {Number2} (int)");
            Console.WriteLine("Are these numbers 30 or contain 30?");
            Console.WriteLine($"Returned (bool): {Task3(Number1, Number2)}");
            Console.WriteLine("--------------------------------------- \n");
            Console.WriteLine("Press a button to go back to task list ... \n");
            Console.ReadKey();
            Program.Main();
        }

        //Controls

        static bool Task1(int num1, int num2)
        {
            if (num1 == num2)
                return true;
            else
                return false;
        }

        static int Task2(int num1, int num2)
        {
            if (num1 == num2)
                return num1 * num2;
            else
                return num1 + num2;
        }

        static bool Task3(int num1, int num2)
        {
            if (num1 == 30 || num2 == 30 || num1 + num2 == 30)
                return true;
            else
                return false;
        }
    }
}