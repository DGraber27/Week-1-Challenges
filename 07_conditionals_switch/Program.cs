using System;

namespace _07_conditionals_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name? ");
            string inputName = Console.ReadLine().ToLower();

            switch (inputName)
            {
                case "fred":
                    Console.WriteLine("Hey Fred, go fuck yourself!");
                    break;
                case "karl":
                    Console.WriteLine("Karl? Who the fuck spells 'Carl' with a K? Go Fuck Yourself!");
                    break;
                case "john":
                    Console.WriteLine("Generic fucking John over here! Get an original fucking name you square!");
                    break;
                default:
                    Console.WriteLine("Hey " + inputName + ", GO FUCK YOURSELF!");
                    break;
            }

            Console.WriteLine("Who are your friends?");
            string friend = Console.ReadLine().ToLower();

            switch (friend)
            {

                case "steve":
                    Console.WriteLine("Who the fuck is steve?");
                    break;

                case "george":
                    Console.WriteLine("Don't know no fuckin' george neither");
                    break;
                case "gary":
                    Console.WriteLine("Did you say Larry?");
                    break;

                default:
                    Console.WriteLine(friend = "? Fuck. Maybe I don't have any friends...");
                    break;
            }
            Console.ReadLine();
        }
    }
}
