using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_submission_assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            myClass Class = new myClass();

            Console.WriteLine("Enter a number");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number (Enter 0 for default (5))"); //It makes us enter an int so 0 will trigger the default
            int y = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("The two numbers you entered added together equal: " + myClass.Addition(x, y));
            Console.ReadLine();
        }
    }
}
