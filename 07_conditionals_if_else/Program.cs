using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace _07_conditionals_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How are you feeling today from 1-5?");
            string feelingNumber = Console.ReadLine();

            if (feelingNumber == "5")
            {
                Console.WriteLine("What, you think you're better than me?");
            }

            else if (feelingNumber == "4")
            {
                Console.WriteLine("Hooray for you, dick.");
            }

            else if (feelingNumber == "3")
            {
                Console.WriteLine("Neutral? Really? What are you Switzerland? Pick a side you pansy!");
            }
            else if (feelingNumber == "2")
            {
                Console.WriteLine("Boo hoo! Go complain somewhere else!");
            }

            else if (feelingNumber == "1")
            {
                Console.WriteLine("What are you gonna cry? No one gives a shit about how you feel!");
            }
            else
            {
                Console.WriteLine("I asked a simple question and you can't even answer that right? Get the fuck outta here!");
            }
            Console.ReadLine();

            bool isOn = true;
            bool isHot = false;

            if (isOn)
            {
                Console.WriteLine("The light is on, its bright.");
            }
            if (isOn == true)
            {
                Console.WriteLine("The light is on.");
            }
            if (isOn && isHot)
            {
                Console.WriteLine("lights on and it's hot");
            }
            if (isOn || isHot)
            {
                Console.WriteLine("light's on or it is hot");
            }
            if (isHot)
            {
                Console.WriteLine("it is not hot");
            }
        }
    }
}
