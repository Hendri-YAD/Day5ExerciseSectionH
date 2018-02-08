using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5ExerciseSectionH
{
    class Program9
    {
        static void Main(string[] args)
        {
            for(int i = 5; i <= 1000; i++)
            {
                if (IsPrime(i))
                    Console.Write("{0} ", i);
            }

            Console.WriteLine();
        }

        static bool IsPrime(int n)
        {
            for (int i = 2; i < n / 2; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
    }
}
