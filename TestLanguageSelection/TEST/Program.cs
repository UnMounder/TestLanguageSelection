using System;

namespace TestLanguageSelection7
{
    class Program
    {
        static void Main(string[] args)
        {
            string language;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hi!");
            Console.WriteLine("Please, select preferred language");
            Console.WriteLine();
            byte selectedPosition = 1;
            ConsoleKeyInfo key;
            for (; ; )
            {
                Menu(selectedPosition);
                key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        selectedPosition = TrueValue(selectedPosition -= 1);
                        break;
                    case ConsoleKey.DownArrow:
                        selectedPosition = TrueValue(selectedPosition += 1);
                        break;
                }
                if (key.Key == ConsoleKey.Enter)
                {
                    language = languageSetter(selectedPosition);
                    break;
                }
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                if (selectedPosition == 1)
                {
                    Console.WriteLine("Hi!");
                    Console.WriteLine("Please, select preferred language");
                    Console.WriteLine();
                }
                if (selectedPosition == 2)
                {
                    Console.WriteLine("Привет!");
                    Console.WriteLine("Пожалуйста, выберите предпочитаемый язык");
                    Console.WriteLine();
                }

            }
            Console.WriteLine();
            if (language == "english")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("You selected");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(" english ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("language");
            }
            if (language == "russian")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Вы выбрали");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(" русский ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("язык");
            }
            Console.ReadKey();
        }
        static byte TrueValue(byte selectedPosition)  //dropping selectedPosition
        {
            switch (selectedPosition)
            {
                case 0:
                    return 2;
                case 3:
                    return 1;
                default:
                    return selectedPosition;
            }
        }
        static void Menu(byte selectedPosition) 
        {
            if (selectedPosition == 1)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("ENGLISH");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("RUSSIAN");
            }
            if (selectedPosition == 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("ENGLISH"); 
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("RUSSIAN");
                Console.ResetColor();                
            }
        }
        static string languageSetter(byte selectedPosition) //initialise language var
        {
            switch (selectedPosition)
            {
                case 1:
                    return "english";
                case 2:
                    return "russian";
            }
            return "english";
        }
    }
}
