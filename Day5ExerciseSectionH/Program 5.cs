using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5ExerciseSectionH
{
    class Program5
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(IntToHexaDec(num));
            Console.WriteLine();
            Console.WriteLine("Input\t\tFunction\tBuilt");

            string hexValue = "", hexBuilt = "";
            
            for(int i=1; i <= 100; i++)
            {
                hexValue = IntToHexaDec(i);
                hexBuilt = i.ToString("X");

                Console.WriteLine("{0}\t\t{1}\t{2}", i, hexValue, hexBuilt);
            }

        }

        static string IntToHexaDec(int num)
        {
            int rem;
            string hexDec = ""; //reverse hexDec Value
            string hexCor = ""; //correct hexDec Value

            if (num == 0)
                return "0";
            
            while(num != 0)
            {
                rem = num % 16;

                if (rem < 10)
                    hexDec = hexDec + rem;
                else
                {                
                    switch (rem)
                    {
                        case 10:
                            hexDec = hexDec + "A";
                            break;
                        case 11:
                            hexDec = hexDec + "B";
                            break;
                        case 12:
                            hexDec = hexDec + "C";
                            break;
                        case 13:
                            hexDec = hexDec + "D";
                            break;
                        case 14:
                            hexDec = hexDec + "E";
                            break;
                        case 15:
                            hexDec = hexDec + "F";
                            break;
                    }
                }

                num = num / 16;
            }

            for (int i = hexDec.Length-1; i >= 0; i--)
            {
                hexCor = hexCor + hexDec.Substring(i, 1);
            }

            return hexCor;
        }
    }
}
