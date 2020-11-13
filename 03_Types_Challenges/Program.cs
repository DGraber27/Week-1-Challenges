using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Types_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b = 967;
            Console.WriteLine(b);

            string taco;
            string burrito = "Yes, please!";
            Console.WriteLine(burrito);

            bool c;
            bool d = true;
            Console.WriteLine(d);

            float fish;
            float buoy = 1.5f;
            Console.WriteLine(buoy);

            string str = " Hello Adventurer," + " time to die!";
            Console.WriteLine(str);

            Console.WriteLine(burrito + "" + str);

            int num = 1995;
            string year = $"I was Born in {num}.";
            Console.WriteLine(year);

            string year1 = "There are " + Convert.ToString(num) + " hawks";
            Console.WriteLine(year1);

            int bYear = Int32.Parse("1995");
            Console.WriteLine("I was born in {0}.", bYear);

        }


    }
}
