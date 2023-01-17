using System;

namespace ConsoleMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            const string KeyOne = "1";
            const string KeyTwo = "2";
            const string keyThree = "3";
            const string keyFour = "4";

            string userInput;
            string setName = "";
            int setPassword;
            int minNumber = 1;
            int maxNumber = 5;
            bool isRepeat = true;

            Random random = new Random();

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();

            while (isRepeat)
            {
                Console.WriteLine("Menu\n");
                Console.WriteLine($"{KeyOne}: Ввести имя\n{KeyTwo}: ChangeConsoleColor\n{keyThree}: Установить пароль\n{keyFour}: Выход "); ;
                userInput = Console.ReadLine();

                Console.Clear();
                switch (userInput)
                {
                    case KeyOne:
                        Console.WriteLine("Введите ваше имя");
                        setName = Console.ReadLine();

                        Console.Clear();
                        break;
                    case KeyTwo:
                        int ChangeConsoleColor = random.Next(minNumber, maxNumber);

                        if (ChangeConsoleColor == 1)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            Console.Clear();
                        }
                        else if (ChangeConsoleColor == 2)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.Clear();
                        }
                        else if (ChangeConsoleColor == 3)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkCyan;
                            Console.Clear();
                        }
                        else if (ChangeConsoleColor == 4)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkMagenta;
                            Console.Clear();
                        }
                        break;
                    case keyThree:
                        Console.WriteLine("Установите пароль");
                        setPassword = Convert.ToInt32(Console.ReadLine());

                        Console.Clear();
                        Console.WriteLine("Введите пароль");
                        int password = Convert.ToInt32(Console.ReadLine());

                        Console.Clear();

                        if (password == setPassword)
                        {
                            Console.WriteLine(setName);
                            Console.WriteLine("\nEnter");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case keyFour:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
