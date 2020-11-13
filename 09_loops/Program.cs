using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0; // number is called a loop control variable or(LCV)
            while (number <=100)
            {
                Console.WriteLine(number);
                number = number + 5;
            }
            Console.ReadLine();

            int number1 = 100;

            for (int i =1; i <= number1; i++) // i is the loop control variable (LCV)
            {
                Console.WriteLine(i);
            }
        }
    }
}
