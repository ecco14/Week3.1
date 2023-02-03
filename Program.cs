using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the speed limit: ");
            
            int speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The speed limit is now set to " + speedLimit);

            Car1 a = new Car1();

            Console.WriteLine("What is the make of the first car: ");
            a.make = Console.ReadLine();

            Console.WriteLine("What is the model of the first car: ");
            a.model = Console.ReadLine();

            Console.WriteLine("What is the speed of the first car: ");
            a.speed = Convert.ToInt32(Console.ReadLine());

            if (speedLimit < a.speed)
            {
                int spd = a.speed - speedLimit;
                Console.WriteLine(spd);

            }
            else
            {
                Console.WriteLine("No ticket needed. ");
            }
            
        }

        public class Car1
        {
            public string make;
            public string model;
            public int speed;

           
        }

    }
}
