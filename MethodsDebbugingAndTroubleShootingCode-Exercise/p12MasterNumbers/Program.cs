using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p12MasterNumbers
{
    class Program
    {

        static bool PalindromeCheck(int i)
        {
            int n = i;
            int reversed = 0;

            while (i > 0)
            {
                int digit = i % 10;
                reversed = reversed * 10 + digit;
                i = i / 10;
            }
            if(n == reversed)
            {
                return true;
            }
             return false;
        }

        static bool SumOfDigitsCheck(int i)
        {
            int sum = 0;
            int digit = 0;

            while(i > 0)
            {
                digit = i % 10;
                sum = sum + digit;
                i /= 10;
            }

            if(sum % 7 == 0)
            {
                return true;
            }

            return false;
         }

        static bool ContainsEvenDigitCheck(int i)
        {
            int digit = 0;

            while(i > 0)
            {
                digit = i % 10;

                if(digit % 2 == 0)
                {
                     return true;
                }
                else
                {
                    i /= 10;
                }
            }
            return false;

        }

        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                bool isPalindrome = PalindromeCheck(i);
                bool SumOfDigits = SumOfDigitsCheck(i);
                bool ContainsEvenDigits = ContainsEvenDigitCheck(i);


                if (isPalindrome && SumOfDigits && ContainsEvenDigits)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
