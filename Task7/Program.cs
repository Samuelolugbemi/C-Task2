using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Hourly Rate: ");
            double hourlyRate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Number of Hours Worked: ");
            int workHour = Convert.ToInt32(Console.ReadLine());
            decimal grossPay = 0;
            if(workHour <= 40){
                grossPay = (decimal)hourlyRate * (decimal)workHour;
            } else if(workHour > 40){
                int laterHour = workHour - 40;
                decimal extraPay = 1.5M * laterHour;
                grossPay = ((decimal)hourlyRate * 40M) + ((decimal)hourlyRate * extraPay);
            }
            Console.WriteLine($"Pay for employee is {grossPay:C}");
        }
    }
}
