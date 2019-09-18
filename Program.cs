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
            Console.WriteLine("=========Erankyuni Production and Arshak Entertainment");
            Console.WriteLine("====================Introducing=====================");
            Console.WriteLine("KENT TIV TU JIGYAR JAN ");
            int s = Int32.Parse(Console.ReadLine());
            int i = 0;
            while (i <= s)
            {
                int h = 0;
                int k = 5;
                Console.WriteLine("");
                while (k > i)
                {
                    Console.Write(" ");
                    k--;
                }
                while (h <= i)
                {
                    Console.Write("**");
                    h++;
                }
                i++;
            }
            Console.ReadLine();



        }



    }


}


