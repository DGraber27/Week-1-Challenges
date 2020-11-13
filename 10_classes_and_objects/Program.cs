using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_classes_and_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating the objects
            Donut dougDonut = new Donut();
            Donut chrisDonut = new Donut();
            Donut nickDonut = new Donut();

            //setting property values
            dougDonut.Filling = "cherry";
            dougDonut.Price = 3;
            dougDonut.Type = "normal";
            dougDonut.IsSpecial = true;
            dougDonut.Toppings = "powdered sugar";
            dougDonut.ToGo = false;

            chrisDonut.Filling = "none";
            chrisDonut.Price = 2;
            chrisDonut.Type = "small";
            chrisDonut.IsSpecial = false;
            chrisDonut.Toppings = " Rainbow sprinkles";
            chrisDonut.ToGo = true;

            nickDonut.Filling = "chocolate";
            nickDonut.Price = 3;
            nickDonut.Type = "normal";
            nickDonut.IsSpecial = true;
            nickDonut.Toppings = "none";
            nickDonut.ToGo = true;

            Console.WriteLine(nickDonut.Filling);

        }
    }
}
