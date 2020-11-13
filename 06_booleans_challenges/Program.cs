using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_booleans_challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = 100d / 2d;
            if (value == 50d)
            {
                Console.WriteLine(true);
            }
            else if (value !=50d)
            {
                Console.WriteLine(false);
            }

            Console.WriteLine("Guess what number I am thinking between 1-20");
            int guessNumber = Convert.ToInt16(Console.ReadLine());
            if (guessNumber <= 7 && guessNumber >= 1)
            {
                Console.WriteLine("Guess Higher!");
            }
            else if (guessNumber <= 14)
            {
                Console.WriteLine("A little higher!");
            }
            else if (guessNumber == 15)
            {
                Console.WriteLine("You win!");
            }

            else if (guessNumber >= 16 && guessNumber <= 20)
                {
                Console.WriteLine("A little Lower!");
                 }
            else
            {
                Console.WriteLine("Can't you read?");
            }

            Console.ReadLine();

        Console.WriteLine("Guess a number between 1 and 20");
            int guess = int.Parse(Console.ReadLine());
           if (guess <= 14 && guess >= 1)
            {
                Console.WriteLine("Too Low");
            }
           else if (guess == 15)
            {
                Console.WriteLine("Winner!");
            }
           else if (guess >=16 && guess <=20)
            {
                Console.WriteLine("Too High");
            }
           else
            {
                Console.WriteLine("Rule breaker huh?");
                Console.ReadLine();
            }
        }



    }
}
