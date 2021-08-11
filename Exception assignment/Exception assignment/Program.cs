using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = new List<int> { 18, 6, 20, 34, 52 };

            try {
                Console.WriteLine("Pick a number.");
                int userNum = Convert.ToInt32(Console.ReadLine());

                foreach (int number in numbersList)
                {
                    Console.WriteLine(number / userNum);
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a whole number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }

            Console.WriteLine("Exited try/catch block");
            Console.ReadLine();
        }
    }
}
