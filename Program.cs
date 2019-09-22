using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Project
{
    class program
        {
            static void Main(string[] args)
            {
            int[] floors = new int[] { 1, 2, 3, 4, 5, 6, 7,8,9,10,11,12,13,14,15,16,17,18,19,20};
            Console.WriteLine("Vor harg es uzum gnas");
            int s = Int32.Parse(Console.ReadLine());

            if (s < floors[0] || s > floors[floors.Length - 1])
            {
                Console.WriteLine("harky goyutyun chuni");
                System.Environment.Exit(1);
            }

            for (int i = 0; i <= s; i++)
            {

                Console.WriteLine(i);
                System.Threading.Thread.Sleep(1000);

                if (i == s)
                {

                    Console.Beep();
                    Console.WriteLine("vor hargic es kanchum");

                    int a = Int32.Parse(Console.ReadLine()); 

                        if (a > s && a < floors[floors.Length - 1]) {
                        for (int l = s; l <= a; l++)
                        {
                            Console.WriteLine(l);
                            System.Threading.Thread.Sleep(1000);
                            if (l == a)
                            {
                                Console.Beep();

                            }
                        }
                    } else if (a < s && a > floors[0])
                    {
                        for (int l = s; l >= a; l--)
                        {
                            Console.WriteLine(l);
                            System.Threading.Thread.Sleep(1000);
                            if (l == a)
                            {
                                Console.Beep();

                            }
                        }
                    }

                    }



                }



            }
         }
     }


