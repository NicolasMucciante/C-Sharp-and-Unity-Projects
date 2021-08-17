using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_submission_assignment_2
{
    class myClass
    {
        public static int Addition(int x, int y = 5)
        {
            if (y == 0)
            {
                y = 5;
            }
            int result = x + y;
            return result;
        }

    }
}
