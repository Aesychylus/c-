using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {   int[] hours = new int[3];
            int fare_calculate;
            
            Console.WriteLine("What type of vehicle was parked. Bike, Car or Bus");
            string a = Console.ReadLine();

            for (int i = 0; i <= (hours.Length - 1) ; i++) 
            {
                Console.WriteLine("Please enter number of parking hours for each vehicle in a chronological order");
                hours[i] = Convert.ToInt32(Console.ReadLine());

            }

            if (a== "bike")
            {
                for (int m=0; m <= (hours.Length-1);m++)
                {
                    if (hours[m] <= 3)
                    {
                        fare_calculate = 2;
                        Console.WriteLine("The parking fare for this person is" + " " + fare_calculate);

                    }

                    if (hours[m] > 3 && hours[m] <= 24)
                    {
                        fare_calculate = 2 + ((hours[m]-3) * 1/2);
                        Console.WriteLine("The parking fare for this person is" + " " + fare_calculate);
                    }

                    if (hours[m] > 24)
                    {
                        fare_calculate = 10;
                        Console.WriteLine("The parking fare for this person is" + " " + fare_calculate);
                    }
                }
            }
            if (a == "car")
            {
                for (int m = 0; m <= (hours.Length - 1); m++)
                {
                    if (hours[m] <= 3)
                    {
                        fare_calculate = 4;
                        Console.WriteLine("The parking fare for this person is" + " " + fare_calculate);

                    }

                    if (hours[m] > 3 && hours[m] <= 24)
                    {
                        fare_calculate = 4 + ((hours[m] - 3) * 1);
                        Console.WriteLine("The parking fare for this person is" + " " + fare_calculate);
                    }

                    if (hours[m] > 24)
                    {
                        fare_calculate = 20;
                        Console.WriteLine("The parking fare for this person is" + " " + fare_calculate);
                    }
                }
            }

            if (a == "bus")
            {
                for (int m = 0; m <= (hours.Length - 1); m++)
                {
                    if (hours[m] <= 3)
                    {
                        fare_calculate = 6;
                        Console.WriteLine("The parking fare for this person is" + " " + "$" + fare_calculate);

                    }

                    if (hours[m] > 3 && hours[m] <= 24)
                    {
                        fare_calculate = 6 + ((hours[m] - 3) * 3 / 2);
                        Console.WriteLine("The parking fare for this person is" + " " + "$" + fare_calculate);
                    }

                    if (hours[m] > 24)
                    {
                        fare_calculate = 30;
                        Console.WriteLine("The parking fare for this person is" + " " + "$" + fare_calculate);
                    }
                }
            }
        }
    }
}
