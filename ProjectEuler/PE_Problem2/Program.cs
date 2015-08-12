using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PE_Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            var upperBound = 4000000;

            var prevFib = 0;
            var curFib = 1;
            var sum = 0;

            while (curFib < upperBound)
            {
                curFib = curFib + prevFib;
                prevFib = curFib - prevFib;

                if (curFib % 2 == 0)
                {
                    Console.WriteLine(curFib);
                    sum += curFib;
                }
            }

            Console.WriteLine(sum);
            Console.ReadLine();

        }
    }
}
