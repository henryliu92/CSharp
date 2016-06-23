using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_non_static_1
{
    class Program
    {
        class Car
        {
            public string carName;
            public string carModel;
            public int price;
            public Boolean noSold;

            public static int noOfCars;

            public void NewCar(string carName, string carModel, int price)
            {
                this.carName = carName;
                this.carModel = carModel;
                this.price = price;
                this.noSold = false;
                noOfCars++;
            }


            public void listCars()
            {
                Console.WriteLine("These are the car details...");
                Console.WriteLine("Brand Name and Model: {0} {1}, car price: £{2:N0}.", carName, carModel, price);
                if (noSold)
                {
                    Console.WriteLine("This car has been sold!.");
                }
                else
                {
                    Console.WriteLine("This car is available in stock.");
                }
                Console.WriteLine();
            }

            public void Sold(bool noSold, int price)
            {
                this.noSold = noSold;
                this.price = price;
                //adjust stock levels
                Car.noOfCars--;
            }
        }


        static void Main(string[] args)
        {
            List<Car> listOfCars = new List<Car>();
            Car.noOfCars = 0;

            //Adding new cars:
            Car car01 = new Car();
            car01.NewCar("BMW", "1 Series", 2340);
            listOfCars.Add(car01);

            Car car02 = new Car();
            car02.NewCar("Renault", "Espace", 7700);
            listOfCars.Add(car02);

            Console.WriteLine("Current, the number of cars under these brands availabel are... {0}", Car.noOfCars);
            Console.WriteLine();

            car01.listCars();
            car02.listCars();

            car02.Sold(true, 350);

            Console.WriteLine("Total number of cars in stock is: {0}", Car.noOfCars);
            Console.WriteLine();
            car01.listCars();
            car02.listCars();

        }
    }
}
