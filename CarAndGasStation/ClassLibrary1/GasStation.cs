using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1
{
   public static class GasStation
    {
        public static void Refill(Car c)
        {
            Random rnd = new Random();
            int addFuel = rnd.Next(10, 50);
            c.Fuel += addFuel;
            Console.WriteLine($"The car was refueld {c.Fuel} litres.");
        }

        public static void PumpUpTires(Car c)
        {
            c.IsDrivable = true;
            Console.WriteLine("The car now is in good state");
        }
        
    }
}
