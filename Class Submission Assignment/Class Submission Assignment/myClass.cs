using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Submission_Assignment
{
    class myClass
    {
        public static void divide(int x) //Static method that will divide a user input in half
        {        
            int result = x / 2;
            Console.WriteLine(result);
        }

        public static void outMethod(out int y) //Out method that takes a variable and multiplies it by 2
        {
            y = 10;
            int result2 = y * 2;
            Console.WriteLine(result2);
        }

        public static void divide(float x) //Method overloading for a float
        {
            float result3 = x / 2;
            Console.WriteLine(result3);
        }
    }
}
