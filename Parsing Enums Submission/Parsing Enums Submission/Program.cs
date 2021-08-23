using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums_Submission
{
    public class Program
    {
        static void Main(string[] args)
        {
            Days days = new Days();

            Console.WriteLine("Enter the current day of the week.");
            string userDay = Console.ReadLine();

            try
            {
                Days.DaysOfTheWeek userEnumDay = (Days.DaysOfTheWeek)Enum.Parse(typeof(Days.DaysOfTheWeek), userDay);
                Console.WriteLine("Your current day is: " + userEnumDay);
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            
            Console.ReadLine();
        }
    }
}
