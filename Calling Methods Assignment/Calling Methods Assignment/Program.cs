using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int userNum = Convert.ToInt32(Console.ReadLine());            

            Console.WriteLine("Your number plus 5 is: " + myClass.addFive(userNum));
            Console.WriteLine("Your number minus 10 is: " + myClass.sub10(userNum));
            Console.WriteLine("Your number divided in half is: " + myClass.inHalf(userNum));

            Console.ReadLine();
        }
        
        
    }
}
