using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a letter");
            string Letter = Console.ReadLine();
            bool isCorrect = Letter == "z";

            while (!isCorrect){
                switch (Letter)
                {
                    case "a":
                        Console.WriteLine("The letter is not a try again");
                        Console.WriteLine("Guess a letter");
                        Letter = Console.ReadLine();
                        break;

                    case "b":
                        Console.WriteLine("The letter is not b try again");
                        Console.WriteLine("Guess a letter");
                        Letter = Console.ReadLine();
                        break;

                    case "f":
                        Console.WriteLine("The letter is not f try again");
                        Console.WriteLine("Guess a letter");
                        Letter = Console.ReadLine();
                        break;

                    case "z":
                        Console.WriteLine("The letter is z good job!");
                        isCorrect = true;
                        break;

                    default:
                        Console.WriteLine("You are wrong try again");
                        Console.WriteLine("Guess a letter");
                        Letter = Console.ReadLine();
                        break;

                }

            }
            Console.ReadLine();



        }
    }
}
