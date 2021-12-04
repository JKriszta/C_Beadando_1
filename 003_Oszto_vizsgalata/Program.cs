using System;

namespace _003_Oszto_vizsgalata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell an integer number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Tell another integer number: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 % num2 == 0)
            {
                int divide = num1 / num2;
                Console.WriteLine($"the number can be divided by second one without remainder: {divide}");
            }
            else
            {
                Console.WriteLine("the number cannot be divided by second one without remainder");
            }

            Console.ReadKey();
        }
    }
}
