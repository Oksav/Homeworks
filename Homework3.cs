using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Names = new string[20];
            Names[0] = "Bianka";
            Names[1] = "Zhizel";
            Names[2] = "John";
            Names[3] = "Doe";
            for (int j = 4; j <= Names.Length; j++)
            {
                Console.WriteLine("Do you wanna enter a name ? ( Y / N)");
                string input = Console.ReadLine();
                if (input == "Y")
                {
                    Console.WriteLine("Please enter a name:");
                    Names[j] = Console.ReadLine();
                }
                else if (input == "N")
                {
                    foreach(var item in Names)
                    {
                        Console.WriteLine(item);
                       
                    }
                    break;
                }
            }
            Console.ReadLine();
           
        }
    }
}
