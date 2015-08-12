using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PE_Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = 600851475143;
            //var value = 13195;
            var primeNumbers = new List<int>();
            var maxPrimeFactor = 0;

            // another thing to remember is that prime numbers are odd numbers after 2 can remove the check for isprime if wanted
            for (var i = 3; i < value; i++)
            {
                if (isPrimeNumber(i)) 
                {
                    var temp = (value % i == 0) ? value % i : 0;
                    if (isPrimeNumber(temp))
                    { 
                        
                    }
                }
            }

            Console.ReadLine();

        }

        public static bool isPrimeNumber(long value)
        {
            if (value != 1 || value != 2 || value != 3) 
            {
                if (value % 2 == 0 || value % 3 == 0)
                {
                    return false;
                }
            }


            return true;        
        }
    }
}
