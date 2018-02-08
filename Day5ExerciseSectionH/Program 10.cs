using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5ExerciseSectionH
{
    class Program10
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the number of Rows for Matrix A: ");
            int rowA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the number of Columns for Matrix A: ");
            int colA = Convert.ToInt32(Console.ReadLine());

            int[,] A = new int[rowA, colA];

            for(int i =0; i <rowA; i++)
            {
                for(int j=0; j < colA; j++)
                {
                    Console.WriteLine("Please enter a value for row {0}: ", i+1);
                    Console.Write("Value {0} is: ", j + 1);
                    A[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("Please enter the number of Rows for Matrix B: ");
            int rowB = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the number of Columns for Matrix B: ");
            int colB = Convert.ToInt32(Console.ReadLine());

            int[,] B = new int[rowB, colB];

            for (int i = 0; i < rowB; i++)
            {
                for (int j = 0; j < colB; j++)
                {
                    Console.WriteLine("Please enter a value for row {0}: ", i + 1);
                    Console.Write("Value {0} is: ", j + 1);
                    B[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int[,] C = MatrixMultiply(A, B);

            Console.WriteLine("New Matrix: ");

            for (int i = 0; i < C.GetLength(0); i++)
            {
                for (int j = 0; j < C.GetLength(1); j++)
                {
                    Console.Write("{0} ", C[i,j]);
                }
                Console.WriteLine();
            }

        }

        static int[,] MatrixMultiply(int[,] A, int[,] B)
        {
            int newRow = A.GetLength(0);
            int newCol = B.GetLength(1);

            int[,] NewMatrix = new int[newRow, newCol];            

            for (int i = 0; i < newRow; i++)
            {
                for(int j=0; j < newCol; j++)
                {
                    for(int z=0;z < A.GetLength(1); z++)
                    {
                        NewMatrix[i, j] = NewMatrix[i, j] + A[i,z] * B[z, j];
                    }
                }
            }

            return NewMatrix;
        }
    }
}
