using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Solution
 * Get the factors of the number
 *  In this case prime factors 
 *  
 * 1. Get a factor of the number: Use % 
 * 2. Check that factor if its a prime : loop and check if values lower than it can divide it 
 * 3. If is a prime, save 
 * 4. Move on to the next number
 */

namespace PE_Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            long maxPrimeFactor = 0;
            long inputValue = 600851475143;
            long value = inputValue;

            // Solution 1
            // Checking each number -- this takes too long to process ._. what to do next 

            // Loop through the first value 
            //for (var i = 2; i < value; i++) 
            //{
            //    if (value % i == 0) 
            //    {
            //        bool isPrime = true;

            //        // Check if the value i is a prime number by cycling through 2 <= j < i 

            //        for (var j = 2; j < i; j++)
            //        {
            //            if (i % j == 0)
            //            {
            //                isPrime = false;
            //                break;
            //            }
            //        }
            //        if (isPrime)
            //        {
            //            maxPrimeFactor = i;
            //        }
            //    }
            //}

            /*
             * Solution 2 
             * 
             * Used help for this brain not strong enough.. Oh brain.. 
             * Apparently there is this "Fundamental theorem of arithmetic" that states that a number is a prime or is a product of prime numbers 
             * Keeping this in mind something like this can be written instead..
             * 
             * 1. Value divide by n ( starting from 2 ) 
             * 2. If % has no remaining value save the results
             * 3. Run step 1 and 2 until there is a remainder THEN
             * 4. Move on to adding the n by 1 
             * 5. If n reaches the value or is lower, stop the loop
             *  5.1 if n^2 is lower than the value stop as well because that number would not be divisible anymore
             */

            var i = 2;
            
            while (i * i <= value)
            {
                // as long as the number can be divided by i, divide it otherwise add 1
                if(value % i == 0)
                {
                    value = value / i;
                    maxPrimeFactor = i;
                }
                else
                {
                    i++;
                }
            }
            if (value > maxPrimeFactor)
            {
                maxPrimeFactor = value;
            }
            
            Console.WriteLine(maxPrimeFactor);
            Console.ReadLine();

        }
    }
}
