﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5ExerciseSectionH
{
    class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two phrases: ");
            Console.Write("Phrase 1: ");
            string s1 = Console.ReadLine();

            Console.Write("Phrase 2: ");
            string s2 = Console.ReadLine();

            if (InString(s1, s2))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");            
        }

        static bool InString(string s1, string s2)
        {
            s1 = s1.ToUpper();
            s2 = s2.ToUpper();

            for(int i = 0; i < (s1.Length - s2.Length + 1); i++)
            {
                if (s2 == s1.Substring(i, s2.Length))
                    return true;
            }

            return false;            
        }
    }
}
