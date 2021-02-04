using System;
using System.Collections.Generic;
using System.Text;

namespace Skip_A_Number
{
    class Checker
    {
        public bool IntCheck(bool checker)
        {
            do
            {
                if (checker == false)
                {
                    Console.WriteLine("Invalid Response");
                }
                else
                {
                    checker = true;
                }
            } while (checker == false);

            return checker;
        }
    }
}
