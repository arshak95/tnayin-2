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
            const Double a = 1.0; 
            const Double b = 4.0;
            const Double c = 3.0;
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



