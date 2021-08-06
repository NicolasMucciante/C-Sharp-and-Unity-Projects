using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailySubmitProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string currentCourse = Console.ReadLine();
            Console.WriteLine("What page number are you on?");
            string currentPage = Console.ReadLine();
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string assistance = Console.ReadLine();
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperience = Console.ReadLine();
            Console.WriteLine("Is there any feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
