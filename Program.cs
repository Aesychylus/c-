using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] hour = new int[3];
            Console.WriteLine("What type of vehicle was parked. Bike, Car or Bus");
            string a = Console.ReadLine();

            for (int i = 0; i <= (hour.Length - 1); i++)
            {
                Console.WriteLine("Please enter number of parking hours for each vehicle in a chronological order");
                hour[i] = Convert.ToInt32(Console.ReadLine());

            }

            Vehicle obj = new Vehicle();

            if (a== "bike")
            {
                obj.Bike(hour);
            }
            if (a == "car")
            {
                obj.Car(hour);
            }

            if (a == "bus")
            {
                obj.Bus(hour);
            }
        }
    }
}
