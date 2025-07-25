using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Activity_35
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Enter a sentence: ");
                string input = Console.ReadLine();
                string output = "";
                bool newWord = true;

            for (int i = 0; i < input.Length; i++)
                {
                    char currentChar = input[i];

            if (currentChar >= 'A' && currentChar <= 'Z')
                    {
                        output += newWord ? currentChar : (char)(currentChar + 32);
                        newWord = false;
                    }
            else if (currentChar >= 'a' && currentChar <= 'z')
                    {
                        output += newWord ? (char)(currentChar - 32) : currentChar;
                        newWord = false;
                    }
            else
                    {
                        output += currentChar;
                        newWord = true; 
                    }
            }
                Console.WriteLine("Formatted Sentence: " + output);
        }
    }
}


