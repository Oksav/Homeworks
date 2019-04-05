using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public class CarExtensions
    {
        public static void Drive(Car c, string x)
        {
            Random rnd = new Random();
            int addFuel = rnd.Next(10, 50);
            Console.WriteLine($"Driving to {x}. And take some {addFuel} litres fuel. ");
        }
    }
}
