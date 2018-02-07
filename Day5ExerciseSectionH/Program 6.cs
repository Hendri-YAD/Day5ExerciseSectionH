using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5ExerciseSectionH
{
    class Program6
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a phrase: ");
            string input = Console.ReadLine();

            Console.Write("Please enter a character to substitute: ");
            char c1 = Convert.ToChar(Console.ReadLine());

            Console.Write("Please a substituted character: ");
            char c2 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine(Substitute(input, c1, c2));
        }

        static string Substitute(string s, char c1, char c2)
        {
            string newStr = "";
            for(int i=0; i < s.Length; i++)
            {
                if(s.Substring(i,1) == c1.ToString())
                {
                    newStr += c2.ToString();
                }
                else
                {
                    newStr += s.Substring(i, 1);
                }
            }

            return newStr;
        }
    }
}
