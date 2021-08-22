using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Submission
{
    public class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int id { get; set; }

        public static bool operator == (Employee x, Employee y) //Overloads the == operator
        {
            if (x.id == y.id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator != (Employee x, Employee y) //This is required to overload the == operator 
        {
            if (x.id != y.id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
