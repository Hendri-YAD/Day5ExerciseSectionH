using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5ExerciseSectionH
{
    class Program11
    {
        static void Main()
        {
            double[] A = new double[] { 3, 6, 9 }; //Testing purposes
            DoubleOps sqrtOp = SquareRoot;

            double[] sqrtA = ProcessArray(A, sqrtOp);
            Console.WriteLine("Square Root: ");

            for(int i = 0; i < A.Length; i++)
            {
                Console.WriteLine("{0} ", sqrtA[i]);
            }

            Console.WriteLine();

            DoubleOps squOp = Square;

            double[] squA = ProcessArray(A, squOp);
            Console.WriteLine("Square: ");

            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine("{0} ", squA[i]);
            }

            Console.WriteLine();

        }

        delegate double DoubleOps(double x);

        static double SquareRoot(double x)
        {
            return Math.Sqrt(x);
        }

        static double Square(double x)
        {
            return Math.Pow(x, 2);
        }

        static double[] ProcessArray(double[] arr, DoubleOps ops)
        {
            int size = arr.Length;
            double[] newArr = new double[size];

            for(int i=0; i<size; i++)
            {
                newArr[i] = ops(arr[i]);
            }

            return newArr;
        }
    }
}
