using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { firstName = "Sample", lastName = "Employee1", id = 1 }; //Creating 2 employees to compare
            Employee employee2 = new Employee() { firstName = "Sample", lastName = "Employee2", id = 2 };

            if(employee1.id == employee2.id) 
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }

            Console.ReadLine();
        }
    }
}
