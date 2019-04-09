using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public partial class Car
    {
        public void StartCar()
        {
            if (Fuel > 0 && HaveKeys == true && IsDrivable == true )
            {
                Console.WriteLine("The car has started.");
                
            }else
            {
                Console.WriteLine("The car has problems. It can not start.");
                
            }
        }

        public void StartLights()
        {
            if(HaveKeys == false)
            {
                Console.WriteLine("Your car doesnt have keys.");
            } else if (HaveKeys == true) {
                Console.WriteLine("The lights are on.");
            }
        }

        public static string GetCarStats(Car v)
        {
            return $" Brand: {v.Brand} \n Model: {v.Model} \n Color: {v.Color} \n Fuel: {v.Fuel} \n Has Keys: {v.HaveKeys} \n Is Drivable: {v.IsDrivable} \n END.";    
        }
        
    }
}
