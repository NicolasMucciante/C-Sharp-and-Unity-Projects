using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");
            //string userName = Console.ReadLine();

            //if (userName == "Nicolas")
            //{
            //    Console.WriteLine("Hello, you are the creator!");
            //}
            //else if (userName == "Nic")
            //{
            //    Console.WriteLine("Hello, you are the creator!");
            //}
            //else
            //{
            //    Console.WriteLine("You are NOT the creator!");
            //}

            //if (2 != 4)
            //{
            //    Console.WriteLine("Yeah that makes sense.");
            //}
            //else
            //{
            //    Console.WriteLine("Well this is awkward...");
            //}

            //Console.ReadLine();

            //int myNumber = 8;

            //if (myNumber > 10)
            //{
            //    Console.WriteLine("Your number is greater than 10!");
            //}
            //else
            //{
            //    Console.WriteLine("Your number is less than 10!");
            //}

            //int num1 = 25;
            //int num2 = 26;

            //string result = num1 > num2 ? "Num 1 is greater than Num 2" : "Num 1 is less than Num 2";
            //Console.WriteLine(result);
            //Console.ReadLine();

            //int currentTemp = 80;
            //int roomTemp = 70;

            //if (currentTemp == roomTemp)
            //{
            //    Console.WriteLine("It is exactly room temperature.");

            //}
            //else if (currentTemp > roomTemp)
            //{
            //    Console.WriteLine("It is warmer then room temp.");
            //}
            //else if (roomTemp > currentTemp)
            //{
            //    Console.WriteLine("Room Temp is warmer than current temp.");
            //}
            //else
            //{
            //    Console.WriteLine("It iis not room Temp");
            //}

            //string comparisonResults = currentTemp == roomTemp ? "It is room temp." : "It is not room temp.";

            //Console.WriteLine(comparisonResults);

            //int roomTemperature = 70;

            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("It is not warmer than room temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("uhhhhh... something went wrong.");
            //}

            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string result = favNum == 12 ? "You have an awesome favorite number" : "You do not have an awesome favorite number, sorry...";
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
