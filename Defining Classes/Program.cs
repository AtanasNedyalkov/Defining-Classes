using System;

namespace CarManufacturer
{
    class Car
    {
        private string make;
        private string model;
        private int year;

        public string Make
        {
            get { return make; }
            set { this.make = value; }
        }
        public string Model
        {
            get { return model; }
            set { this.model = value; }
        }
        public int Year
        {
            get { return year; }
            set { this.year = value; }
        }

    }


    class Program
    {

        static void Main()
        {
            Car car = new Car();

            car.Make = "Vw";
            car.Model = "MK3";
            car.Year = 1992;
            Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
        }


    }
}

