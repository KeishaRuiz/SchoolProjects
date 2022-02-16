using System;

namespace CarProject
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your speed limit:");

            string speedMph = Console.ReadLine();

            Console.WriteLine("Speed limit: " + speedMph + "mph");


            Console.WriteLine("Enter car make:");

            string carMake = Console.ReadLine();

            Console.WriteLine("Enter car model:");

            string carModel = Console.ReadLine();

            Console.WriteLine("Enter car speed:");

            string carSpeed = Console.ReadLine();


            Car c1 = new Car();

            c1.make = carMake;
            c1.model = carModel;
            c1.speed = int.Parse(carSpeed);

            Console.WriteLine(carMake + " " + carModel + ": " + c1.speed + "mph");

            //

            /*Console.WriteLine("Enter your speed limit:");

            speedMph = Console.ReadLine();

            Console.WriteLine("Speed limit: " + speedMph + "mph");*/


            Console.WriteLine("Enter car make:");

            carMake = Console.ReadLine();

            Console.WriteLine("Enter car model:");

            carModel = Console.ReadLine();

            Console.WriteLine("Enter car speed:");

            carSpeed = Console.ReadLine();

            Car c2 = new Car();

            c2.make = carMake;
            c2.model = carModel;
            c2.speed = int.Parse(carSpeed);

            Console.WriteLine(carMake + " " + carModel + ": " + c2.speed + "mph");

            //

            /*Console.WriteLine("Enter your speed limit:");

            speedMph = Console.ReadLine();

            Console.WriteLine("Speed limit: " + speedMph + "mph");*/


            Console.WriteLine("Enter car make:");

            carMake = Console.ReadLine();

            Console.WriteLine("Enter car model:");

            carModel = Console.ReadLine();

            Console.WriteLine("Enter car speed:");

            carSpeed = Console.ReadLine();

            Car c3 = new Car();

            c3.make = carMake;
            c3.model = carModel;
            c3.speed = int.Parse(carSpeed);

            Console.WriteLine(carMake + " " + carModel + ": " + c3.speed + "mph");


            //////

            int demerits = 0;

            if (c1.speed < int.Parse(speedMph))
            {
                Console.WriteLine(c1.make + c1.model + ": " + c1.speed + "mph" + "OK");
            }
            else
            {
                int over = c1.speed - int.Parse(speedMph);
                demerits = (over / 5);

                if (demerits > 10)
                {
                    Console.WriteLine(c1.make + c1.model + ": " + c1.speed + "mph" + "License Suspended");
                }
            }


            //////

            demerits = 0;
            if (c2.speed < int.Parse(speedMph))
            {
                Console.WriteLine(c2.make + c2.model + ": " + c2.speed + "mph" + "OK");
            }
            else
            {
                int over = c2.speed - int.Parse(speedMph);
                demerits = (over / 5);

                if (demerits > 10)
                {
                    Console.WriteLine(c2.make + c2.model + ": " + c2.speed + "mph" + "License Suspended");
                }
            }


            //////

            demerits = 0;
            if (c3.speed < int.Parse(speedMph))
            {
                Console.WriteLine(c3.make + c3.model + ": " + c3.speed + "mph" + "OK");
            }
            else
            {
                int over = c3.speed - int.Parse(speedMph);
                demerits = (over / 5);
                if (demerits > 10)
                {
                    Console.WriteLine(c3.make + c3.model + ": " + c3.speed + "mph" + "License Suspended");
                }
            }

        }
    }
}

public class Car
{
    public string make;

    public string model;

    public int speed;


}


