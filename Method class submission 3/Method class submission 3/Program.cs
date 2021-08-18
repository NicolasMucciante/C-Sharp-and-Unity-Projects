using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_class_submission_3
{
    class Program
    {
        static void Main(string[] args)
        {           
            myClass Class = new myClass();

            Console.WriteLine("Enter a number to be multiplied by 2");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a number to be displyed on the screen");
            int y = Convert.ToInt32(Console.ReadLine());

            myClass.multiply(x, y);

            Console.ReadLine();

        }
    }
}
