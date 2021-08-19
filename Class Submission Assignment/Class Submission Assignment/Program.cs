using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Submission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int y; //Declaring a variable and not giving it a value so we can use it in the output method

            Console.WriteLine("Enter a number");
            int userNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your number divided in half is: ");
            myClass.divide(userNum); //Divide method will take the user input and divide it in half

            Console.WriteLine("This is an example of a out method...");
            myClass.outMethod(out y); //Output method

            Console.WriteLine("Enter a decimal number");
            float userNum2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Your decimal number divided in half is: ");
            myClass.divide(userNum2);


            Console.ReadLine();
        }
    }
}
