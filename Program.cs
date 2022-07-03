using System;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            string a;
            Console.WriteLine("Please enter the designation of the employee");
            a = Console.ReadLine();

            SalarySlip engineer = new SalarySlip(1500, 100, 500);

            SalarySlip manager = new SalarySlip(1500, 250, 1000);

            SalarySlip analyst = new SalarySlip(1500, 150, 800);

            


            if (a == "engineer")

            {
                
                total = engineer.basicPay + engineer.fuel + engineer.medical;
                Console.WriteLine("The total salary of this designation including allowances is" + " " + "$" + total);
            }

            if (a == "manager")
            {
                total = manager.basicPay + manager.fuel + manager.medical;
                Console.WriteLine("The total salary of this designation including allowances is" + " " + "$" + total);
            }

            if (a == "analyst")
            {
                total = analyst.basicPay + analyst.fuel + analyst.medical;
                Console.WriteLine("The total salary of this designation including allowances is" + " " + "$" + total);
            }

        }
    }
}
