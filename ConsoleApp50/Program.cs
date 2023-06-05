namespace ConsoleApp50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string commandCloseProgram = "exit";
            string userInput;
            bool userInExit = false;

            while (userInExit == false)
            {
                Console.WriteLine("Введите команду - " + "\"" + commandCloseProgram + "\"" + " для закрытия программы.");
                userInput = Console.ReadLine();

                if (userInput == commandCloseProgram)
                {
                    userInExit = true;
                }
            }
        }
    }
}