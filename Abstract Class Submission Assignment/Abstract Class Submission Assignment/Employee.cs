using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Submission_Assignment
{
    public class Employee : Person, IQuittable
    {
        public void SayName()
        {
            Console.WriteLine("Name : " + firstName + " " + lastName);
        }
        public void Quit()
        {
            Console.WriteLine("It worked!");
        }
    }
}
