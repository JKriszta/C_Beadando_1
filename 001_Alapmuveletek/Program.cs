using System;

namespace _001_Alapmuveletek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell an integer number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Tell another integer number: ");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;
            int substract;
            int multiply = num1 * num2;
            double divide;


            if (num1 > num2)
            {

                substract = num1 - num2;
                divide = num1 / num2;
            }
            else
            {
                substract = num2 - num1;
                divide = num2 / num1;
            }




            Console.WriteLine($"sum: {sum}");
            Console.WriteLine($"substract*: {substract}");
            Console.WriteLine($"multipy: {multiply}");
            // Console.WriteLine($"divide*: {divide}");
            Console.WriteLine($"divide*: {divide:0.00##}");



            Console.ReadKey();
        }
    }
}
