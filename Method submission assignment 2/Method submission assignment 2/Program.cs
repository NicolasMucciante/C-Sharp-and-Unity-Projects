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
            int y;
            string yText;

            Console.WriteLine("Enter a number");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number or enter for default");
            yText = Console.ReadLine();

            try
            {
                y = int.Parse(yText);
            }
            catch
            {
                Console.WriteLine("No input received using default 5");
                y = 5;
            }

            Console.WriteLine("The two numbers you entered added together equal: " + myClass.Addition(x, y));

    Console.ReadLine();
        }
    }
}
