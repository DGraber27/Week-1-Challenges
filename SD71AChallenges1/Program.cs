using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD71AChallenges1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Challenge One
            Console.WriteLine("Challenge One: Self Info\n\n");
            string firstName = "Drew";
            string lastName = "Graber";
            int age = 25;

            Console.WriteLine($"{firstName} {lastName} is {age} years old.\n\n");


            //Challenge Two           0                      1                      2              3
            Console.WriteLine("Challenge Two: Favorite Books\n\n");
            string[] favBooks = { "Ready Player One", "Blood Sweat and Pixels", "Eldest", "Console Wars" };

            foreach (var item in favBooks)
            {
                Console.WriteLine(item + "\n");
            }


            //Challenge Three
            Console.WriteLine("Challenge Three: Dates in list\n");
            var list = new List<DateTime>();
            list.Add(new DateTime(1980, 5, 5));
            list.Add(new DateTime(1982, 10, 20));
            list.Add(new DateTime(1984, 1, 4));
            list.Add(new DateTime(1979, 6, 19));
            //List<DateTime[]> list = new List<DateTime[]>() { new[] { DateTime.Now, DateTime.Now }, new[] { DateTime.Today, DateTime.UtcNow } };

            foreach (var item in list)
            {
                Console.WriteLine(item + "\n");
            }


            //Challenge Four
            Console.WriteLine("Challenge Four: Age operation 7\n\n");
            int sumPlus = age + 7;
            int sumMinus = age - 7;
            double sumDivide = age / 7;
            int sumMult = age * 7;
            int sumMod = age % 7;

            Console.WriteLine($"{sumPlus} \n\n" +
                $"{sumMinus} \n\n" +
                $"{sumDivide} \n\n" +
                $"{sumMult} \n\n" +
                $"{sumMod} \n\n");



            //Challenge Five 

            Console.WriteLine("Challenge Five: Hours slept\n\n");
            Console.WriteLine("How many hours have you slept?");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput >= 10)
            {
                Console.WriteLine("Wow that's a lot of sleep!");
            }

            else if (userInput >= 8 && userInput < 10)
            {
                Console.WriteLine("You feel well rested.");
            }
            else if (userInput >= 4 && userInput < 8)
            {
                Console.WriteLine("Bummer");
            }
            else
            {
                Console.WriteLine("You either didn't sleep or were in a coma.... Are you okay?");
            }

            //Challenge Six 
            //Write out a switch case that evaluates a variable that holds the value for how the user's day has been.
            // Have a case for: "Great", "Good", "Okay", "Bad", ":(" and output a response to the Console for each.
            bool replay = true;
            while (replay == true)
            {
                Console.WriteLine("Challenge Six: How was your day?\n\n");
                Console.WriteLine("How was your day?\n" +
                    "1. Great\n" +
                    "2. Good \n" +
                    "3. Okay \n" +
                    "4. Bad");
                string answer = Console.ReadLine().ToUpper();
                switch (answer)
                {
                    case "1":
                    case "Great":
                        Console.WriteLine("What, you think you're better than me?");
                        break;
                    case "2":
                    case "Good":
                        Console.WriteLine("Good? What do you mean by good? Talk to me!");
                        break;
                    case "3":
                    case "Okay":
                        Console.WriteLine("Woah, jeez. Didn't know you were so angry.");
                        break;
                    case "4":
                    case "Bad":
                        Console.WriteLine("Have you ever heard of the Tragedy of Darth Plagueis the Wise?");
                        string answerTwo = Console.ReadLine().ToLower();
                        if (answerTwo == "yes")
                        {
                            Console.WriteLine("Execute Order 66!");
                        }
                        else if (answerTwo == "no")
                        {
                            Console.WriteLine(" I thought not.\n It's not a story the Jedi would tell you. \n It's a Sith legend. Darth Plagueis was a Dark Lord of the Sith, so powerful and so wise he could use the Force to influence the midichlorians to create life...\n He had such a knowledge of the dark side that he could even keep the ones he cared about from dying. The dark side of the Force is a pathway to many abilities some consider to be unnatural. He became so powerful... \nthe only thing he was afraid of was losing his power, which eventually, of course, he did. Unfortunately, he taught his apprentice everything he knew, then his apprentice killed him in his sleep. \n It's ironic he could save others from death, but not himself.");
                        }
                        else { Console.WriteLine("I am the senate!"); }
                        break;
                    default:
                        Console.WriteLine("Wise guy, eh? You can't follow instructions! Goodbye!\n");
                        break;
                }
                Console.WriteLine("Would you like to ask again?");
                string answerThree = Console.ReadLine().ToLower();
                if (answerThree == "no")
                {
                    replay = false;
                }
            }

        }
    }
}
