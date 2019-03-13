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
            ////Task1
            //Console.WriteLine("-------------TASK 1-------------");
            //Console.WriteLine("Please enter your string");
            //string text = Console.ReadLine();
            //if(IsPalindrome(text))
            //{
            //    Console.WriteLine($" The string you entered \"{text}\"  is Palindrome");
            //}
            //else
            //{
            //    Console.WriteLine($" The string you entered \"{text}\" is not a Palindrome");
            //}
            //Console.WriteLine("-------------TASK 2-------------");
            ////Task2
            //Console.WriteLine("Please enter the lenght of the array:");
            //int lenght2 = int.Parse(Console.ReadLine());
            //int[] array2 = new int[lenght2];
            //for(int i=0;i< lenght2;i++)
            //{
            //    Console.WriteLine($"Please enter the {i} integer to the array");
            //    array2[i]=int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine($" The greatest value of array2 is \"{FindMaximum(array2)}\".");
            ////Task3
            //Console.WriteLine("-------------TASK 3-------------");
            //Console.WriteLine("Please enter text here:");
            //string str = Console.ReadLine();
            //char[] array = str.ToCharArray();
            //int arrayNumbers = 0;
            //int vowels = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    // Checks if char is digit
               
            //    if (array[i] >= '0' && array[i] <= '9')
            //    {
            //        arrayNumbers += 1;
            //    } ;
            //    // Checks if char is vowel
            //    if (array[i] == 'a' || array[i] == 'e' || array[i] == 'i' || array[i] == 'o' || array[i] == 'u')
            //    {
            //        vowels += 1;
            //    } 
            //}
            //Console.WriteLine($"In the string \"{str}\" there are {arrayNumbers} digits and {vowels} vowels.");
            ////Task4
            //Console.WriteLine("-------------TASK 4-------------");
            //Console.WriteLine("Please enter your text");
            //string str1 = Console.ReadLine();
            //int lenght = str1.Length;
            //char[] arr1 = str1.ToCharArray(0, lenght); // Converts string into char array.
            //char ch;

            //Console.Write("\nAfter conversion, the string is : ");
            //for (int i = 0; i < lenght; i++)
            //{
            //    ch = arr1[i];
            //    if (Char.IsLower(ch)) // check whether the character is lowercase
            //        Console.Write(Char.ToUpper(ch)); // Converts lowercase character to uppercase.
            //    else
            //        Console.Write(Char.ToLower(ch)); // Converts uppercase character to lowercase.
            //}
            //Console.ReadLine();
            ////Task5
            //Console.WriteLine("-------------TASK 5-------------");
            //Console.Write("Please input a character: ");
            //char cha = (char)Console.Read();
            //if (Char.IsLetter(cha))
            //{
            //    if (Char.IsUpper(cha))
            //    {
            //        Console.WriteLine($"\nThe character you entered \"{cha}\" is uppercase.\n");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"\nThe character you entered \"{cha}\" is lowercase.\n");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("\nThe entered character is not an alphabetic character.\n");
            //}
            ////Task6
            //Console.WriteLine("-------------TASK 6-------------");
            //Console.WriteLine("Please input a string you want to check: ");
            //string stringCheck = Console.ReadLine().ToLower();

            //Console.WriteLine("Please input a subString to check the occurencies in the given string. ");
            //string subStr = Console.ReadLine().ToLower(); ;

            //Console.WriteLine($"The {subStr} appears {Occurences(stringCheck,subStr)} in entered string \"{stringCheck}\"");
            ////Task7
            //Console.WriteLine("-------------TASK 7-------------");
            //Console.WriteLine("Please input a number you want to check power: ");
            //double number1=double.Parse(Console.ReadLine());
            //Console.WriteLine("Please input the exponent: ");
            //int number2 = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{number1} raised to {number2} = {Pow(number1,number2)}");
            ////Task8
            //Console.WriteLine("-------------TASK 8-------------");
            //Console.WriteLine("Please input number how many days in advance you want to check: ");
            //int days = int.Parse(Console.ReadLine());
            //DateTime TimeNow = DateTime.Now;
            //DateTime nDay = TimeNow.AddDays(+days);
            //Console.WriteLine($"The day after {days} days is {nDay.ToString("dddd")}.");
            //Task9
            Console.WriteLine("-------------TASK 9-------------");
            Console.WriteLine("Please input number how many years before you want to check what day it was: ");
            int sin = 0;
            while (true)
            {
                int digits = int.Parse(Console.ReadLine());
                if (digits<20)
                {
                    sin = digits;
                    break;
                }
                Console.WriteLine("Error invalid entry, Please enter again:");
            }
            if (sin != 0)
            {
                Console.WriteLine($"{sin} years from now it was {Year(sin).Date} and it was {Year(sin).ToString("dddd")}.");
            }

        }
        public static bool IsPalindrome(string text)
        {
            if (text.Length <= 1)
                return true;
            else
            {
                if (text[0] != text[text.Length - 1])
                    return false;
                else
                    return IsPalindrome(text.Substring(1, text.Length - 2));
            }
        }
        static int FindMaximum(int[] arr)
        {
            int max = arr[0];
            int i;
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }
        static int Occurences(string str1, string val)
        {
            int occurrences = 0;
            int startingIndex = 0;

            while ((startingIndex = str1.IndexOf(val, startingIndex)) >= 0)
            {
                ++occurrences;
                ++startingIndex;
            }

            return occurrences;
        }
        public static double Pow(double basevalue, int exponentvalue)
        {
            if (exponentvalue == 0)
            {
                return 1;
            }
            if (exponentvalue == 1)
            {
                return basevalue;
            }
            return basevalue * Pow(basevalue, exponentvalue - 1);
        }
        static DateTime Year(int n)
        {
           return DateTime.Now.AddYears(-n);
        }
    }
}
