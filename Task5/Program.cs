using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int smallest = 0;
            int value = 0;
            for (int i = 1;i <= 5; i++)
            {
                Console.Write($"Enter No {i}: ");
                value = Convert.ToInt32(Console.ReadLine());
                if (i == 1){
                smallest = value;
                }
                else if (value < smallest){
                smallest = value;
                }
                }
                Console.WriteLine("The smallest number you entered was {0}", smallest);
                Console.ReadLine();
        }
    }
}
