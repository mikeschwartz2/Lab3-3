using System;
using System.Collections.Generic;

namespace Lab3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string rerun;
            string reverse;
    
            do
            {
                Console.Write("Please enter what you would like reversed: ");
                reverse = Console.ReadLine();

                reverse = Reverse(reverse);

                ///////Enter another word
                Console.Write("Would you like to reverse another word? y/n: ");
                rerun = Console.ReadLine();
                rerun = rerun.ToLower();

                

                Console.WriteLine();

                while (rerun != "y" && rerun != "n")
                {
                    Console.WriteLine("This is not a valid input. Would you like to continue: y/n");
                    rerun = Console.ReadLine();
                    rerun = rerun.ToLower();
                }
            }
            while (rerun == "y");


            static string Reverse(string str)
            {
                int i = 0;
                Stack<char> stack = new Stack<char>();
                //Console.WriteLine($"Before Reverse: {str}");

                while( i < str.Length )
                {
                     stack.Push(str[i]);
                    i++;
                }

                Console.Write("The word you entered reversed is: ");
                while (stack.Count > 0)
                {
                    Console.Write(stack.Pop());
                }
                Console.WriteLine();

                return str;
            }
        }

        

    }
}
