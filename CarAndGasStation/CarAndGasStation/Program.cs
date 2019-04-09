using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;



namespace CarAndGasStation
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Car fuck = new Car("Toyota", "Blue", "Celica", 10, true, false);

            fuck.StartCar();
            string fucks = Car.GetCarStats(fuck);
            Console.WriteLine(fucks);

            GasStation.Refill(fuck);
            GasStation.PumpUpTires(fuck);
            string fucks1 = Car.GetCarStats(fuck);
            Console.WriteLine(fucks1);
            CarExtensions.Drive(fuck, "Skopje");
            
            

            Console.ReadLine();
        }
    }
}
