/*
 * A palindromic number reads the same both ways. 
 * The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
 * Find the largest palindrome made from the product of two 3-digit numbers.
 * 
 * Solution 1 is as below
 * Solution 2 - Found after checking for the right answer - seems for quicker 
 *  1. Get the square of 999
 *  2. Iterate from the results until the palindrome is found
 *  3. To get the values
 *      3.1 let i be the first value within 99 and 1000
 *      3.2 check if the result / i is within 99 and 1000 (only 3 digits) and use mod to make sure it has no remainders  
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Through iteration 
            var largestPalindrome = 0;

            var lowerBound = 99;
            var upperBound = 999;
            bool found = false;
            
            for (var i = upperBound; i > 99; i--)
            {
                for (var j = upperBound; j > 99; j--)
                {
                    var temp = i * j;
                    if (isPalindrome(temp) && temp > largestPalindrome)
                    {
                        largestPalindrome = i * j;
                    }
                }
            }
            Console.WriteLine(largestPalindrome);
            Console.ReadLine();
        }

        public static bool isPalindrome(long value)
        {
            string valueInString = value.ToString();

            for (var i = 0; i <= valueInString.Length/2; i++)
            {
                if (valueInString[i] != valueInString[(valueInString.Length - 1) - i])
                {
                    return false;
                }
            }


            return true;
        }
    }
}
