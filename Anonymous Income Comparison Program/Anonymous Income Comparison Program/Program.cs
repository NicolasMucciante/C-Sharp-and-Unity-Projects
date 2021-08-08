using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Income_Comparison_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // PERSON 1
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1:");
            Console.WriteLine("Please enter your hourly pay rate.");
            float personOneHourly = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your hours worked per week.");
            float personOneWorked = Convert.ToInt32(Console.ReadLine());


            //PERSON 2
            Console.WriteLine("Person 2:");
            Console.WriteLine("Please enter your hourly pay rate.");
            float personTwoHourly = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your hours worked per week.");
            float personTwoWorked = Convert.ToInt32(Console.ReadLine());
            float personOneAnnual = personOneHourly * personOneWorked * 52;
            float personTwoAnnual = personTwoHourly * personTwoWorked * 52;

            //COMPARISONS
            Console.WriteLine("Annual salary of Person 1: " + personOneAnnual);
            Console.WriteLine("Annual salary of Person 2: " + personTwoAnnual);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(personOneAnnual > personTwoAnnual);

            Console.ReadLine();

        }
    }
}
