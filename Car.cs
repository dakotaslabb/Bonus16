using System;
using System.Collections.Generic;
using System.Text;

namespace Bonus_16
{
    class Car
    {

        private string make;
        private string model;
        private int year;
        private double price;

        public string Make
        {
            get
            {
                return make;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }

        }

        public double Price
        {
            get
            {
                return price;
            }
        }
        //public Car()
        //{
        //    this.make = "Cart";
        //    this.model = "with wheels";
        //    this.year = 1900;
        //    this.price = 100.00;
        //}

        public Car(string make, string model, int year, double price)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
        }
        public override string ToString()
        {
            return ($"{make}\t{model}\t{year}\t{price}");
        }
    }
}
