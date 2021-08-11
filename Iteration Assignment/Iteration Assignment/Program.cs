using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            ////This is an array of states that allows the user to enter 1 state
            //Console.WriteLine("What state do you live in?");
            //string userState = Console.ReadLine();
            //string[] states = new string[5];
            //states[0] = "Texas";
            //states[1] = "Florida";
            //states[2] = "California";
            //states[3] = "Ohio";
            //states[4] = userState;
            //Console.WriteLine("Current list of states: ");

            //for (int i = 0; i < states.Length; i++) //This will iterate through the list and display it on screen
            //{
            //    Console.WriteLine(states[i]);
            //}

            ////Changed the while loop to an if statement to fix infinite loop
            //if (states.Length == 5)
            //{
            //    Console.WriteLine("There are " + states.Length + " states in the array.");
            //}


            //List<string> names = new List<string> { "Nick", "Matthew", "Abby", "Bob"};
            ////A loop that uses < to determine weather to continue the loop
            //for(int i = 0; i < names.Count; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}

            //List<string> pokemon = new List<string> { "Squirtle", "Charizard", "Scorbunny", "Snom" };

            //for (int j = 0; j <= pokemon.Count - 1; j++)
            //{
            //    Console.WriteLine(pokemon[j]);
            //}

            //List<string> seahawks = new List<string> { "russell wilson", "chris carson", "dk metcalf", "tyler lockett"};
            //Console.WriteLine("Please enter a seahawks player name to search.");
            //string userSearch = Console.ReadLine();
            //int idx = seahawks.IndexOf(userSearch);
            //int counter = 0;

            ////These if statements are going to look through the entire list before it sends the error message
            //foreach (string player in seahawks)
            //{
            //    if(userSearch == player)
            //    {
            //        Console.WriteLine("Player found at index: " + idx);
            //        break;
            //    }
            //    if (userSearch != player)
            //    {
            //        counter++;
            //    }
            //    if (counter >= seahawks.Count)
            //    {
            //        Console.WriteLine("Sorry, your input wasnt found in the list.");
            //    }

            //}


            //List<string> fruitsList = new List<string> { "apple", "banana", "kiwi", "grape", "apple", "mango", "apple", "banana" };
            //List<string> fruitCount = new List<string>();
            //Console.WriteLine("What is your favorite fruit?");
            //string userFruit = Console.ReadLine();           
            //int counter2 = 0;

            //for (int i = 0; i < fruitsList.Count; i++)
            //{
            //    if (userFruit == fruitsList[i])
            //    {
            //        fruitCount.Add(userFruit);
            //        userFruit = fruitsList[i];
            //    }
            //    if (userFruit != fruitsList[i])
            //    {
            //        counter2++;
            //    }
            //    if (counter2 >= fruitsList.Count)
            //    {
            //        Console.WriteLine("Sorry, your fruit isnt in the list.");
            //        break;
            //    }
            //}
            //Console.WriteLine("Your favorite fruit is in the list: " + fruitCount.Count + " times!");

            List<string> vegetablesList = new List<string> { "lettus", "potato", "onion", "celery", "potato" };
            List<string> vegetableDuplicate = new List<string>();
            string dupe = " ";

            foreach (string vegetable in vegetablesList)
            {
                vegetableDuplicate.Add(vegetable);
                if ()
                {
                    Console.WriteLine("There are duplicates in the list.");
                }
            }
            foreach (string vegetable in vegetableDuplicate)
            {
                Console.WriteLine(vegetable);
            }

            Console.ReadLine();
        }
    }
}
