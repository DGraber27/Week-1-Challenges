using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName;
            string wholeName = "Drew Graber";

            string first = "the cars we sell are ";
            string second = "BMW, Lexus, and Mercedes. ";
            Console.WriteLine(first + second);

            string firstName = "Jenn";
            string lastName = "Williams";
            Console.WriteLine("Her name is {0} {1}.", firstName, lastName);

            Console.WriteLine($"Her name is {firstName} {lastName}");

            string taco = "taco";
            string nacho = "nachos";
            Console.WriteLine(taco + " or " + nacho);
            Console.WriteLine("Shoud I get a {0} or {1}? ", taco, nacho);
            Console.WriteLine($"Should I get a {taco} or {nacho}? ");
        }
        }
    }

