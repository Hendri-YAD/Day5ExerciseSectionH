using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5ExerciseSectionH
{
    class Program7
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter a value for the array: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int[] ar = new int[size];

            SetArray(ar, num);

            for (int i = 0; i < ar.Length; i++)
            {
                Console.WriteLine("Array {0} is {1}", i, ar[i]);
            }
        }

        static void SetArray(int[] arr, int value)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = value;
            }
        }
    }
}
