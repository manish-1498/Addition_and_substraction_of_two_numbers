using System;

namespace sum_and_sumbtract_of_two_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            int minus = a - b;
            Console.WriteLine("Sum of two numbers is :" + sum);
            Console.WriteLine("subtraction of two numbers is :" + minus);
        }
    }
}
