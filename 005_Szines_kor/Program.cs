using System;

namespace _005_Szines_kor
{
    internal class Program
    {

        static void SayBye()
        {
            string text = "Bye";
            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, (Console.WindowHeight / 2) + 1);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Bye");
        }


        static void Main(string[] args)
        {
            Console.Write("name: ");
            string name = Console.ReadLine();

            Console.Write("born:");
            int born = int.Parse(Console.ReadLine());

            DateTime dt = DateTime.Now;
            int year = dt.Year;

            int age = year - born;

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            string text = $"{name}, your age is: { age}";


            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, Console.WindowHeight / 2);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{name}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(", your age is: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{age}");
            SayBye();


            Console.ReadKey();
        }
    }
}
