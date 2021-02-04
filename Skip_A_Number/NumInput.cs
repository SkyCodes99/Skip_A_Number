using System;
using System.Collections.Generic;
using System.Text;

namespace Skip_A_Number
{
    class NumInput
    {
        private bool numCheck;
        private bool check;
        private Checker checkClass = new Checker();
        public int LowNum(int lowNum)
        {
                string lowNumString = Console.ReadLine();
                check = int.TryParse(lowNumString, out lowNum);
                numCheck = checkClass.IntCheck(check);
                return lowNum;
        }
        public int HighNum(int highNum)
        {
            string highNumString = Console.ReadLine();
            check = int.TryParse(highNumString, out highNum);
            numCheck = checkClass.IntCheck(check);
            return highNum;
        }
        public int DivisibleNum(int divisible)
        {
            string divisibleString = Console.ReadLine();
            check = int.TryParse(divisibleString, out divisible);
            numCheck = checkClass.IntCheck(check);
            return divisible;
        }

        public string Phrase(string phrase)
        {
            check = false;
            do
            {
                phrase = Console.ReadLine();
                if (phrase.Length > 6)
                {
                    Console.WriteLine("Invalid Response");
                }
                else if(phrase.Length == 0)
                {
                    Console.WriteLine("Enter a phrase");
                }
                else
                {
                    check = true;
                }
            } while (check == false);

            return phrase;
        }
    }
}
