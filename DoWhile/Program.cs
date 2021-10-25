using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess my name?");
            string name = Console.ReadLine();
            bool isGuessed = name == "Andrew";

            do
            {

                switch (name)
                {
                    case "John":
                        Console.WriteLine("My name is not John. Try again");
                        Console.WriteLine("Guess my name?");
                        name = Console.ReadLine();
                        break;

                    case "Alex":
                        Console.WriteLine("My name is not Alex. Try again");
                        Console.WriteLine("Guess my name?");
                        name = Console.ReadLine();
                        break;

                    case "Donald":
                        Console.WriteLine("My name is not Donald. Try again");
                        Console.WriteLine("Guess my name?");
                        name = Console.ReadLine();
                        break;

                    case "Andrew":
                        Console.WriteLine("My name is Andrew! Good job!");
                        isGuessed = true;
                        
                        break;

                    default:
                        Console.WriteLine("You are wrong try again");
                        Console.WriteLine("Guess my name?");
                        name = Console.ReadLine();
                        break;
                }
            }
            while (!isGuessed);
            Console.ReadLine();


        }
    }
}
