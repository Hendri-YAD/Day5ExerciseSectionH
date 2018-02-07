using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5ExerciseSectionH
{
    class Program2
    {
        static void Main(string[] args)
        {
            int[] ar = new int[] { 0, 1,2,3 };
            PrintArray(ar);
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
        }
    }
}
