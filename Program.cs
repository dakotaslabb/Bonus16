using System;
using System.Collections.Generic;
using System.Linq;
namespace Bonus_16
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> newCar = new List<Car>();

            newCar.Add(new Car("Nikolai", "Model S", 2017, 54999.99));
            newCar.Add(new Car("Ford", "Edge", 2017, 31999.90));
            newCar.Add(new Car("Chewie", "Vette", 2017, 44989.95));
            newCar.Add(new Car("Hyonda", "Prior", 2017, 23795.50));


            Console.WriteLine("Welcome to the world of buying cars\n");
            Console.WriteLine("How many cars do you want to add?\n");

            string numberOfCars = Console.ReadLine();
            int carNumber = int.Parse(numberOfCars);

            if (carNumber == 0)
            {
                Console.WriteLine("\nHere are the cars we have in stock.\n");
            }
            else
            {
                for (int i = 1; i <= carNumber; i++)
                {
                    Console.WriteLine($"\nWhat is the Make of car #{i}?\n");
                    string make = Console.ReadLine();

                    Console.WriteLine($"What is the Model of car #{i}?\n");
                    string model = Console.ReadLine();

                    Console.WriteLine($"What is the Year of car #{i}?\n");
                    string year1 = Console.ReadLine();
                    int year = int.Parse(year1);

                    Console.WriteLine($"What is the Price of car #{i}?\n");
                    string price1 = Console.ReadLine();
                    double price = double.Parse(price1);

                    newCar.Add(new Car(make, model, year, price));
                }
            }

            Console.WriteLine("\nCurrent Inventory:\n");

            for (int i = 0; i < newCar.Count; i++)
            {
                Car c = newCar[i];
                Console.WriteLine($"{c.Make}\t{ c.Model}\t{c.Year}\t${c.Price}\n");
            }
        }
    }
}
