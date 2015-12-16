using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_Problem5
{
    public class Factor
    {
        public int[] Value { get; set; }
        public int[] Exponent { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
                What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
                Basically the problem is asking for the GCF of the numbers from 1 to 20 
            */

            var highestFactors = new Dictionary<int, Factor>();
            /*
                for each of the value 
                get the factors 
                    how to get the factors ? 
                        there is a previous solution where I got the prime factors of an integer      
                
            */

            for (var i = 1; i < 21; i++)
            {
                var factors = new Factor();

                var curFactor = 2;
                while (i % curFactor == 0)
                {
                    if (highestFactors.ContainsKey(i))
                    {
                        
                    }
                }
            }
        }
    }
}
