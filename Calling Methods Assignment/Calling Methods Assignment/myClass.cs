using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_Assignment
{
    class myClass
    {
        public static int addFive(int userNum)
        {
            int addResult = userNum + 5;
            return addResult;
        }

        public static int sub10(int userNum)
        {
            int subResult = userNum - 10;
            return subResult;
        }

        public static int inHalf(int userNum)
        {
            int half = userNum / 2;
            return half;
        }
    }
}
