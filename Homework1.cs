using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 5
            int[] Numbers = new int[5];
            int j = 0;
            while(j <= Numbers.Length-1)
            {
                Console.WriteLine($"Please enter value for the {j} element");
                Numbers[j] = Convert.ToInt32(Console.ReadLine());
                j++;
            }
            Console.WriteLine("You have entered all the values");
            
            int sum = 0;
            for(int i=0; i <= Numbers.Length -1; i++)
            {
                sum += Numbers[i];
            }
            Console.WriteLine($"The sum from all elements in the array is: {sum}");
            Console.ReadLine();
            
            #endregion
            
        }

    }
}
