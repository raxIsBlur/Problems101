using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PE_Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            var upperBound = 1000;
            var sum = 0;

            for (var i = 0; i < upperBound; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
