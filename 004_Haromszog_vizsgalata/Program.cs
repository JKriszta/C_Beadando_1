using System;

namespace _004_Haromszog_vizsgalata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Triangle 1. side lenght: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Triangle 2. side lenght: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Triangle 3. side lenght: ");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 * num3 + num3 * num2 > num1 * num2)
            {
                Console.WriteLine("Can be triange");
            }
            else
            {
                Console.WriteLine("Cannot be triange");
            }


            Console.ReadKey();
        }
    }
}
