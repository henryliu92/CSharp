using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForStatement
{
    class For1
    {
        static void Main(string[] args)
        {
            string[] sevenDwarves = { "Happy", "Doc", "Sleepy", "Sneezy", "Dopey", "Bashful", "Grumpy" };
            string supper = "";
            string drink = "";

            for (int i = 0; i < sevenDwarves.Length; i++)
            {
                Console.WriteLine("What do you want for Supper, " + sevenDwarves[i] + "?");
                // ("What do you want for Supper, " + sevenDwarves[i] + "?"); can be deleted so that no additional typing is involved in the debugging. 
                supper = Console.ReadLine();
                Console.WriteLine("Here is your Supper  " + sevenDwarves[i] + " and ");
            }

            foreach (string dwarf in sevenDwarves)
            {
                Console.WriteLine("here is your drink    " + dwarf + ".");
            }
            Console.ReadLine();

        }
    }
}
