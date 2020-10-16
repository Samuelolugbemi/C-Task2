using System;

namespace CalculatorTest
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Console Calculator");

            Console.Write("Please Enter First Number: ");
            double firstNum = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please Enter Second Number: ");
            double secondNum = Convert.ToDouble(Console.ReadLine());

            // Console.Write("Enter 1 to add,\n 2 to sub,\n 3 to divide,\n 4 to multiply,\n 5 to modulus: ");
            // int operation = Convert.ToInt32(Console.ReadLine());

            // if(operation == 1){
            // Console.WriteLine($"The answer is {firstNum + secondNum}");
            // }
            // if(operation == 2){
            // Console.WriteLine($"The answer is {firstNum - secondNum}");
            // }
            // if(operation == 3){
            //      if(secondNum == 0){
            //         Console.WriteLine("The answer is 0");
            //     }
            // else{
            //     Console.WriteLine($"The answer is {firstNum / secondNum}");
            // }
            // if(operation == 4){
            //    Console.WriteLine($"The answer is {firstNum * secondNum}");
            // }
            // }
            // if(operation == 5){
            // Console.WriteLine($"The answer is {firstNum % secondNum}");
            // } else{
            // Console.WriteLine($"Invalid Operation");
            // }
            Console.Write("Enter 1 to add,\n 2 to sub,\n 3 to divide,\n 4 to multiply,\n 5 to modulus: ");
            int operation = Convert.ToInt32(Console.ReadLine());
            switch (operation)
            {
                case 1:
                    Console.WriteLine($"The answer is {firstNum + secondNum}");
                    break;
                case 2:
                    Console.WriteLine($"The answer is {firstNum - secondNum}");
                    break;
                 case 3:
                    Console.WriteLine($"The answer is {firstNum / secondNum}");
                    break;
                 case 4:
                    Console.WriteLine($"The answer is {firstNum * secondNum}");
                    break;
                 case 5:
                    Console.WriteLine($"The answer is {firstNum % secondNum}");
                    break;            
                default: 
                Console.WriteLine("Ivalid Operation");
                break;
            }        }
    }
}
