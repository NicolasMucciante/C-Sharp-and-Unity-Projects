using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Submission
{
    class myClass
    {
        public static int mathOperation(int userNum)
        {
            int result = userNum * 2;
            return result;
        }

        public static int mathOperation(float userNumF)
        {
            int result2 = (int)(userNumF + 5.0F);
            return result2;
        }

        public static int mathOperation(string myString)
        {
            int myInt = Convert.ToInt32(myString) - 10;

            return myInt;
        }
    }
}
