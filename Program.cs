using System;

namespace Arithmetic_Functions
{
    class Program
    {
        static int sum(int a, int b)
        {
            return a + b;
        } 
        static int sub(int a, int b)
        {
            return a - b;
        }
        static int star(int a, int b)
        {
            return a * b;
        }
        static int div(int a, int b)
        {
            return a / b;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter First Intger: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Intger: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Sum = {sum(a,b)} | Difference = {sub(a,b)} | Product = {star(a,b)} | Division = {div(a,b) }");
        }
    }
}
