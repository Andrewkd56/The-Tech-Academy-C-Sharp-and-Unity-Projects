using System;
using System.Collections.Generic;


namespace arrayListsAssignment
{
    class Program
    {
        static void Main()
        {
            string[] stringArray = new string[] { "Matt", "Tony", "Ezekial", "Brad" };
            Console.WriteLine("please choose a number from 0 to 3");
            int num = Convert.ToInt32(Console.ReadLine());
           if (num > 3)
            {
                Console.WriteLine("That index does not exist sorry");
                Console.ReadLine();
                return;
            }
             Console.WriteLine(stringArray[num]);
            Console.ReadLine();
            
            int[] numArray = new int[] { 200, 8652, 45845, 22, 3, 456 };
            Console.WriteLine("Please choose a number from 0 to 5");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 > 5)
            {
                Console.WriteLine("Sorry there are no values at that index.");
                Console.ReadLine();
                return;
            }
            Console.WriteLine(numArray[num1]);
            Console.ReadLine();

            List<string> Teams = new List<string>();
            Teams.Add("Chargers");
            Teams.Add("Raiders");
            Teams.Add("Broncos");
            Teams.Add("Chiefs");

            Console.WriteLine("Choose a number from 0 - 3");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num2 > 3)
            {
                Console.WriteLine("Sorry that does not exist");
                Console.ReadLine();
                return;
            }
            Console.WriteLine(Teams[num2]);
            Console.ReadLine();



        }
    }
}
