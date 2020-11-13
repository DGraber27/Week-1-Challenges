using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _07_conditionals_ternary_expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;

            if (number == 7)
                Console.WriteLine("the number is 7.");
            else
                Console.WriteLine("the number is not 7.");

            string response = ((number == 7) ? "the number is 7." : "the number is not 7.");
            Console.WriteLine(response);

            Console.WriteLine("would you like a taco? yes or no?");
            string taco = Console.ReadLine().ToLower();

            switch (taco)
            {
                case "yes":
                    Console.WriteLine("lets get some tacos!");
                    break;
                case "no":
                    Console.WriteLine("Then fuck off!");
                    break;
                default:
                    Console.WriteLine("Well? Answer the question!");
                    break;
            }
            Console.ReadLine();

            int value = 45;

            string answer = ((value == 45) ? "the number is 45" : "the number is something else");
            Console.WriteLine(answer);

            
        }
    }
}
