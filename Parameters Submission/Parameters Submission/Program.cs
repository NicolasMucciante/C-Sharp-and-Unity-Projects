using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string>() { "Pen", "Paper", "Desk", "Computer" }; //This is creating a list of strings

            Employee<int> employee1 = new Employee<int>();
            employee1.Things = new List<int>() { 1, 5, 36, 15, 10 }; //This is the list of ints

            for (int i = 0; i < employee.Things.Count; i++) //These loops are going to print the 2 lists to the console
            {
                Console.WriteLine(employee.Things[i]);
            }
            for (int j = 0; j < employee1.Things.Count; j++)
            {
                Console.WriteLine(employee1.Things[j]);
            }

            Console.ReadLine();
        }
    }
}
