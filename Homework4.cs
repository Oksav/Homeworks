using System;
using static Homework4.School;

namespace Homework4

{
    class Program
    {
        static void Main(string[] args)
        {

            Student[] userArray = new Student[5]{
               new Student("Vasko", "SEDC","G2"),
               new Student("Viktor","SEDC","G2"),
               new Student("Bojan","SEDC","G2"),
               new Student("Igor","SEDC","G2"),
               new Student("Filip", "SEDC", "G2")
           };

            Console.WriteLine("Enter a name for the student you have been searching for:");
            string search = Console.ReadLine();
            for (int i = 0; i < userArray.Length; i++)
            {
                if (search == userArray[i].Name)
                {
                    Console.WriteLine($"We have found the student: \n {userArray[i].Name}, who at the moment is visiting the academy \n {userArray[i].Academy} and currently he is with group \n {userArray[i].Group}.");
                    break;
                }
                else if (search != userArray[i].Name)
                {
                    Console.WriteLine("We didn't match the input!.");
                    break;
                };

            }

            Console.ReadLine();
        }
    }
}
