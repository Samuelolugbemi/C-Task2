using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Your name is {name} and age is {age}");

        }
    }
}
