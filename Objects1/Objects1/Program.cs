using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects1
{
    class Car
    {
        public string carname;
        public string carmodel;
        public int price;

        public static int noOfCars;

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Car> noOfCars = new List<Car>();
            Car car01 = new Car();
            car01.carname = "BMW";
            car01.carmodel = "1426";
            car01.price = 500;
            Car.noOfCars++;

            Car car02 = new Car();
            car02.carname = "Renault";
            car02.carmodel = "Espace";
            car02.price = 7000;
            Car.noOfCars++;

            Car car03 = new Car();
            car03.carname = "Golf";
            car03.carmodel = "1223 Red";
            car03.price = 1890;
            Car.noOfCars++;

            Console.WriteLine("Currently, the number of cars in stock: {0}", Car.noOfCars);
            Console.WriteLine();

            Console.WriteLine("Details for car 1 include... ");
            Console.WriteLine("Brand Name: {0}, Model: {1}, the price: £{2:N0}. ", car01.carname, car01.carmodel, car01.price);
            Console.WriteLine("Details for car 2 include... ");
            Console.WriteLine("Brand Name: {0}, Model: {1}, the price: £{2:N0}. ", car02.carname, car02.carmodel, car02.price);
            Console.WriteLine("Details for car 3 include... ");
            Console.WriteLine("Brand Name: {0}, Model: {1}, the price: £{2:N0}. ", car03.carname, car03.carmodel, car03.price);

            Console.ReadLine();
        }
    }
}
