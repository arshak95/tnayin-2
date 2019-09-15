using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Project
{
    class Program
    {
        static void Main(string[]args )

        {
            Double a, b, c;
            Console.WriteLine( "a in tiv tveq");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b in tiv tveq");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("c in tiv tveq");
            c = Convert.ToDouble(Console.ReadLine()); ;



            Double x1;
            Double x2;

           Double D= Math.Pow(b, 2) - 4 * a * c;
           if (D > 0 || D == 0) 
        {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);

                Console.WriteLine(x1);
                Console.WriteLine(x2);

            }
          


        }
    }
}



