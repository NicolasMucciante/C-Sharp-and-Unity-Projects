using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Submission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };
            IQuittable employee1 = new Employee() { firstName = "Sample", lastName = "Student2" };

            employee.SayName();
            employee1.Quit();

            Console.ReadLine();
        }
    }
}
