using System;
using System.Collections.Generic;


namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main()
        {
            //string[] teamNames = { "Charger", "Raider", "Chief", "Bronco", "Jet", "Patriot" };
            //Console.WriteLine("Please type something in");
            //string userInput = Console.ReadLine();

            //for (int i = 0; i < teamNames.Length; i++)
            //{
            //    teamNames[i] = teamNames[i] + userInput;
            //    Console.WriteLine(teamNames[i]);
            //}
            //Console.WriteLine(teamNames[0]);
            //Console.ReadLine();

            //for (int i = 0; i <= teamNames.Length; i++)
            //{
            //    teamNames[i] = teamNames[i] + userInput;
            //    Console.WriteLine(teamNames[i]);
            //}
            //Console.WriteLine(teamNames[0]);
            //Console.ReadLine();

            //foreach (string team in teamNames)
            //{
            //    Console.WriteLine("The New Team Name is " + team);
            //}
            //Console.ReadLine();

            //for (int a = 0; a < 50; a--)
            //{
            //    Console.WriteLine("value : {0}", a);
            //}
            //Console.ReadLine();
            //for (int a = 0; a < 50; a++)
            //{
            //    Console.WriteLine("value : {0}", a);
            //}
            //Console.ReadLine();

            //List<string> anime = new List<string>() { "Dragonball", "Naruto", "Onepiece", "AttackonTitan", "Inuyasha", "My Hero Acadamia" };
            //Console.WriteLine("Guess an anime?");
            //string animeName = Console.ReadLine();
            //bool isGuessed = false;
            //do
            //{
            //    switch (animeName)
            //    {
            //        default:
            //            Console.WriteLine("That anime is not here please try again");
            //            Console.WriteLine("Guess an anime?");
            //            animeName = Console.ReadLine();
            //            break;

            //        case "Dragonball":
            //            Console.WriteLine("You picked the anime" + animeName + "You are correct");
            //            isGuessed = true;
            //            Console.ReadLine();
            //            return;

            //        case "Naruto":
            //            Console.WriteLine("You picked the anime" + animeName + "You are correct");
            //            isGuessed = true;
            //            Console.ReadLine();
            //            return;

            //        case "Onepiece":
            //            Console.WriteLine("You picked the anime" + animeName + "You are correct");
            //            isGuessed = true;
            //            Console.ReadLine();
            //            return;

            //        case "AttackonTitan":
            //            Console.WriteLine("You picked the anime" + animeName + "You are correct");
            //            isGuessed = true;
            //            Console.ReadLine();
            //            return;

            //        case "Inuyasha":
            //            Console.WriteLine("You picked the anime" + animeName + "You are correct");
            //            isGuessed = true;
            //            Console.ReadLine();
            //            return;

            //        case "My Hero Acadamia":
            //            Console.WriteLine("You picked the anime" + animeName + "You are correct");
            //            isGuessed = true;
            //            Console.ReadLine();
            //            return;

            //    }
            //}

            //while (!isGuessed);
            //Console.ReadLine();

            //List<string> firstNames = new List<string>() { "John", "Eric", "John", "Ashley", "Chelsey" };
            //Console.WriteLine("Please enter a first name");
            //string guessName = Console.ReadLine();
            //for (int i = 0; i < firstNames.Count; i++)
            //{

            //    if (firstNames[i] == "John")
            //    {
            //        Console.WriteLine(firstNames.IndexOf("John"));
            //    }
            //}
            //Console.ReadLine();


            //Console.WriteLine("\n\nPress enter to display team list with duplications");
            //Console.ReadLine();
            //List<string> teamList = new List<string>();
            //teamList.Add("cubs");
            //teamList.Add("red sox");
            //teamList.Add("yankees");
            //teamList.Add("cubs");
            //teamList.Add("yankees");
            //teamList.Add("yankees");

            //foreach (string teams in teamList)
            //{
            //    Console.WriteLine(teams);
            //}

            //Console.WriteLine("Select an item in the list: ");
            //string teamSelected = Console.ReadLine();
            //List<int> indexList = new List<int>();


            //if (teamList.Contains(teamSelected))
            //{
            //    for (int index = 0; index < teamList.Count; index++)
            //        if (teamList[index] == teamSelected)
            //            Console.WriteLine(index);
            //}
            //else { Console.WriteLine("That is not an option!"); }

            //Console.ReadLine();

            List<string> Objects = new List<string>() { "ball", "hoop", "rocket", "ball"};

            foreach (string item in Objects)
            {
                if (item == "ball")
                {
                    Console.WriteLine(item + " appears twice in this list");
                }

                if (item == "hoop")
                {
                    Console.WriteLine(item + "appears once in this list");
                }

                if (item == "rocket")
                {
                    Console.WriteLine(item + " appears once in this list");
                }

                        

            }

            Console.ReadLine();

        }
    }
}
