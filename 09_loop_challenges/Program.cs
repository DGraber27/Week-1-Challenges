using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _09_loop_challenges
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 500; i <= 525; i++)
            {
                Console.WriteLine(i);
            }

            for (int b = 0; b <=100;b= b+5)
            {
                Console.WriteLine(b);
            }

            for (int a = 1; a <= 100; a++)
            {
           
                if (a % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (a % 3 ==0)
                {
                    Console.WriteLine("Fizz");
                }

                else if (a % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(a);
                }

                

            }
        }
    }
}
