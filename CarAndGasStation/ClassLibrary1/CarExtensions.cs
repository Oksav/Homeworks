using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public static class CarExtensions
    {
        public static void Drive(this Car c, string x)
        {
            Random rnd = new Random();
            int addFuel = rnd.Next(10, 50);
            Console.WriteLine($"Driving to {x} with my {c.Brand}. And take some {addFuel} litres fuel. ");
        }
    }
}
