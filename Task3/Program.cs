using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Your Name starts with - {name.Substring(0,1)}");
        }
    }
}
