using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Insurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int personAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? Please enter \"true\" or \"false\"");
            bool duiYN = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTicket = Convert.ToInt32(Console.ReadLine());

            bool qualified = (personAge > 15 && duiYN == false && speedingTicket < 3);
            Console.WriteLine("Are you qualified?: ");
            Console.WriteLine(qualified);

            Console.ReadLine();
        }
    }
}
