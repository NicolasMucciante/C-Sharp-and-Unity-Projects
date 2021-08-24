using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Submission
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeesList = new List<Employee> //Creating a new list of employees
            {
            new Employee() { fName = "Nick", lName = "Mucciante", id = 1 }, 
            new Employee() { fName = "Joe", lName = "Thomas", id = 2 },
            new Employee() { fName = "Matthew", lName = "Larson", id = 3 },
            new Employee() { fName = "Spongebob", lName = "Squarepants", id = 4 },
            new Employee() { fName = "Gary", lName = "Snail", id = 5},
            new Employee() { fName = "Sandy", lName = "Cheeks", id = 6 },
            new Employee() { fName = "Sheldon", lName = "Plankton", id = 7 },
            new Employee() { fName = "Eugene", lName = "Crabs", id = 8 },
            new Employee() { fName = "Squidward", lName = "Tentacles", id = 9 },
            new Employee() { fName = "Joe", lName = "Smith", id = 10 }
        };
            List<Employee> JoeList = new List<Employee>(); //Creating a new list for employees named Joe

            foreach (Employee employee in employeesList) //This loop parses the employeeList for employees named Joe and adds them to the JoeList
            {
                if(employee.fName == "Joe")
                {
                    JoeList.Add(employee);
                }
            }

            List<Employee> JoeList2 = employeesList.Where(x => x.fName == "Joe").ToList(); //This does the same thing as the foreach loop

            List<Employee> employees2 = employeesList.Where(x => x.id > 5).ToList(); //This will make a new list of every employee with an ID higher than 5


            Console.ReadLine();
        }
    }
}
