using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine("The current time is: ");
            Console.WriteLine(currentTime);

            Console.WriteLine("Enter a number.");
            int userNum = Convert.ToInt32(Console.ReadLine());
            DateTime hoursLater = currentTime.AddHours(userNum);
            Console.WriteLine("In {0} hours it will be {1}!", userNum, hoursLater);
          
            Console.ReadLine();
        }
    }
}
