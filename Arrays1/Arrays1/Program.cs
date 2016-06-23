
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Array1
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int total = 0;
            double average;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Emter 5 numbers to be average and then press 'Enter'. ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                total += numbers[i];
            }

            foreach (int number in numbers)
            {
                Console.WriteLine("You typed the number " + number);
            }
            average = total / numbers.Length;
            Console.WriteLine("The total is " + total);
            Console.WriteLine("The average is  " + average);

            Console.ReadLine();
        }
    }
}
