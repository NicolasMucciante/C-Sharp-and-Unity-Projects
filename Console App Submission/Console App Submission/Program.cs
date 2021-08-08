using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is the While statement
            string currentDay = "Sunday";
            Console.WriteLine("What is today?");
            string userDay = Console.ReadLine();

            while(userDay != currentDay)
            {
                Console.WriteLine("I dont think so. Enter another day.");
                userDay = Console.ReadLine();
                Console.ReadLine();
            }

            if(userDay == currentDay)
            {
                Console.WriteLine("Seems right to me, the guessing game is only open on Sundays.");
                Console.ReadLine();
            }

            //This is the do while statement

            Console.WriteLine("Welcome to the guessing game!");
            Console.WriteLine("I have my secret number, please guess what it is!");
            int playerGuess = Convert.ToInt32(Console.ReadLine());
            int secretNum = 77;
            

            bool isGuessed = false;
            do
            {
                if (playerGuess == 77)
                {
                    Console.WriteLine("CORRECT THE NUMBER WAS " + secretNum);
                    isGuessed = true;
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, that is not correct. Try Again.");
                    playerGuess = Convert.ToInt32(Console.ReadLine());
                }
            }
            while (!isGuessed);

           

        }
    }
}
