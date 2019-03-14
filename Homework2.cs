using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[20];
            string[] newArray = new string[20];
            for (int i= 0; i <= newArray.Length-1; i++)
            {
                
                newArray[i] = Console.ReadLine();
                Numbers[i] = int.Parse(newArray[i]);
                Console.WriteLine("You have entered a number.");
                
            }
           
            foreach(var x in Numbers)
            {
                if(x == 0)
                {
                    Console.WriteLine("Skipped");
                }
                else if(x >= 100) {
                    Console.WriteLine("Printing stops here.");
                    break;
                }
                else
                {
                    Console.WriteLine(x);
                }
            }
                


            Console.ReadLine();
        }
    }
}
