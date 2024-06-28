using System;
using System.Collections.Generic;
using System.Text;

namespace NumberOfStepsToReduceANumberToZero
{
    public class Solution
    {
        public static int NumberOfSteps(int num)
        {
            int output = 0;
            while (num != 0)
            {
                if (num % 2 == 0) { num /= 2; }
                else { num--; }
                output ++;
            }
            return output;
        }
    }
}
