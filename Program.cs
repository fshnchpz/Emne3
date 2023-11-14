namespace Emne3
{
    public class Program
    {
        private static string FullName = "Johnny Truong";
        private static bool Bypass = false;
        private static char TaskLoad = '1';

        //My tasks, fill in
        static List<string> Tasks = new List<string>() {
            "ifElse",
            "switchCase",
            "loops",
            "numberCroc"
        };


        //Console Starts Main()
        public static void Main()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Hi, you have arrived at {FullName}'s C# tasks for StartIT Module 3");
            Console.WriteLine("Which task would you like to check out?");
            Console.WriteLine("---------------------------------");
            for (int i = 0; i < Tasks.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] : {Tasks[i]}");
            }
            Console.WriteLine("---------------------------------");

            Console.ForegroundColor = ConsoleColor.White;

            char taskChoice;

            if (Bypass)
            {
                taskChoice = TaskLoad;
                Console.WriteLine("Press any button to continue ..");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Please type in the task number ..");
                taskChoice = Console.ReadKey().KeyChar;
            }


            //Check which task chosen, and run it
            if (taskChoice == '1')
            {
                ifElse.Load();
            }
            else if (taskChoice == '2')
            {
                switchCase.Load();
            }
            else if (taskChoice == '3')
            {
                loops.Load();
            }
            else if (taskChoice == '4')
            {
                numbercroc.Load();
            }
        }
    }
}