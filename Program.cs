using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your name");
            string name = Console.ReadLine();
            Console.WriteLine("How old are you");
            int age = Convert.ToInt32(Console.ReadLine());
            {
                if (age < 23) 
                Console.WriteLine("you are so young");
                if  (age >= 23) 
                Console.WriteLine("Can we meet ? ))");
                Console.WriteLine($" {name},  ");
                Console.ReadKey(); 

                    


            }
















        }
    }
}
