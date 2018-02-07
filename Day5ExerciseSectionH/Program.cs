using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5ExerciseSectionH
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an integer: ");
            int num = ReadInteger(Console.ReadLine());

            Console.WriteLine("The integer is {0}", num);
        }

        static int ReadInteger(string message)
        {
            int num=0;
            bool isNotInt = true;

            if (Int32.TryParse(message, out num))
                isNotInt = false;            

            while (isNotInt)
            {
                Console.Write("Please enter a valid integer: ");
                message = Console.ReadLine();
                if (Int32.TryParse(message, out num))
                    isNotInt = false;                
            }

            return num;
        }
    }
}
