using System;

namespace Skip_A_Number
{
    class Engine
    {
        static void Main(string[] args)
        {
            NumInput numInputClass = new NumInput();
            Console.WriteLine("Enter the low number: ");
            int finalLowNum = 0;
            finalLowNum = numInputClass.LowNum(finalLowNum);
            Console.WriteLine("Enter the high number: ");
            int finalHighNum = 0;
            finalHighNum = numInputClass.HighNum(finalHighNum);
            Console.WriteLine("Enter a number between (1-10): ");
            int finalDivisible = 0;
            finalDivisible = numInputClass.DivisibleNum(finalDivisible);
            Console.WriteLine("Enter a phrase up to 6 characters long: ");
            string divisPhrase = " ";
            divisPhrase = numInputClass.Phrase(divisPhrase);
            for (int i = finalLowNum; i <= finalHighNum; i++)
            {
                if(i % finalDivisible == 0)
                {
                    Console.WriteLine($"{divisPhrase}");
                }
                else
                {
                    Console.WriteLine($"{i}");
                }
            }
        }
    }
}
