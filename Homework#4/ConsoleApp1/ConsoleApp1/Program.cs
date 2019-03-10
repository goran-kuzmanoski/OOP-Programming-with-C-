using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter integer number to check it's factoriel:");
            int number;
            bool convertNumber = int.TryParse(Console.ReadLine(), out number);
            if(convertNumber)
            {
                Console.WriteLine($"Factoriel of {number} ={Factoriel(number)}");
             }
            else
            {
                Console.WriteLine("You entered invalid string");
            }
            Console.WriteLine("Please enter text here:");
            string str = Console.ReadLine();

            int counter = CountWords(str);
            int countSpaces = str.Count(Char.IsWhiteSpace);
            int countChars = str.Count();
            
            Console.WriteLine($"The text contains {counter} words; {countSpaces} spaces and {countChars} total charachters.");

        }
        static int Factoriel(int number)
        {
            if (number==1)
            {
                return 1;
            }
            else
            {
                return number * Factoriel(number - 1);
            }
        }
        private static int CountWords(string S)
        {
            if (S.Length == 0)
                return 0;

            S = S.Trim();
            while (S.Contains("  "))
                S = S.Replace("  ", " ");
            return S.Split(' ').Length;
        }
    }
}
