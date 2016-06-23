using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> listOfBooks = new List<string>() { "The Big Four", "Black Coffee", "A Crab with Golden Claws", "Harry and the treasure of Eddie Carver", "Truth Stick", "" };
            string userOptions;
            string response;
            do
            {
                Console.WriteLine("These are the books on the system. Options include: Add, Delete, Show List or Sort Alphabetically or press 'X' to exit.");
                userOptions = Console.ReadLine().ToUpper();

                switch (userOptions)
                {
                    case "A":
                        Console.WriteLine("What book do you want to Add to database?");
                        response = Console.ReadLine();
                        listOfBooks.Add(response);
                        break;

                    case "D":
                        Console.WriteLine("What book do you want to Remove?");
                        listOfBooks.Remove(Console.ReadLine());
                        break;

                    case "L":
                        foreach (string seeBooks in listOfBooks)
                            Console.WriteLine(seeBooks + "");
                        break;
                    case "S":
                        listOfBooks.Sort();
                        Console.WriteLine("All books have been sorted in Alpabetic Order");
                        break;
                    default:
                        break;
                }

            } while (userOptions != "X");

        }
    }
}
