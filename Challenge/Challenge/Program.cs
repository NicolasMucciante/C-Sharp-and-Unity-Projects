using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus Five = " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //double quotient = 100.0 / 17.0;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //int remainder = 200 / 3;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool trueOrFalse = 12 < 5;
            //Console.WriteLine(trueOrFalse.ToString());
            //Console.ReadLine();

            //int roomTemp = 70;
            //int currentTemp = 70;

            //bool isWarm = currentTemp <= roomTemp;
            //bool isWarm = currentTemp != roomTemp;

            //Console.WriteLine(isWarm);
            //Console.ReadLine();

            Console.WriteLine("Please enter a number between 1-100.");
            int userNum = Convert.ToInt32(Console.ReadLine());

            int result = userNum * 50;
            Console.WriteLine("Your number multiplied by 50 is: " + result);

            Console.WriteLine("Please enter another number between 1-100.");
            int userNum2 = Convert.ToInt32(Console.ReadLine());
            int result2 = userNum2 + 25;
            Console.WriteLine("Your number plus 25 is: " + result2);

            Console.WriteLine("Please enter another number between 1-100.");
            float userNum3 = Convert.ToInt32(Console.ReadLine());
            float result3 = (float)(userNum3 / 12.5);
            Console.WriteLine("Your number divided by 12.5 is: " + result3);

            Console.WriteLine("Please enter another number between 1-100.");
            int userNum4 = Convert.ToInt32(Console.ReadLine());
            bool result4 = userNum4 > 50;
            Console.WriteLine("Your number is greater than 50: " + result4);

            Console.WriteLine("Please enter another number between 1-100.");
            int userNum5 = Convert.ToInt32(Console.ReadLine());
            int result5 = userNum5 % 7;
            Console.WriteLine("Your number divided by 7 has a remainder of: " + result5);

            Console.ReadLine();


        }
    }
}
