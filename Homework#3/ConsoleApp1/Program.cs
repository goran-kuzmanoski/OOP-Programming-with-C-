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
            Console.Write("number1 = ");
            int number1 = int.Parse(Console.ReadLine());

            //Task 1

            if (number1 > 2)
            {
                Console.Write($"Numbers from 1 to {number1} that can be devided by 3:");

                for (int i = 1; i <= number1; i++)
                {
                    if (i % 3 == 0)
                    {
                        Console.Write($"{i},");
                    }
                }
            }
            else
            {
                Console.WriteLine($"Incorect number input!");
            }
            Console.ReadLine();
            //Task 2
            if (number1 > 5)
            {
                Console.Write($"Numbers from 1 to {number1} that can be devided by 2 and 3:");

                for (int i = 1; i <= number1; i++)
                {
                    if (i % 3 == 0 && i % 2 == 0)
                    {
                        Console.Write($"{i},");
                    }
                }
            }
            else
            {
                Console.WriteLine($"Incorect number input!");
            }
            Console.ReadLine();
            //Task 3
            int product = 1;
            while (number1 != 0)
            {
                int r;
                r = number1 % 10;
                number1 = number1 / 10;
                product *= r;
            }
            Console.WriteLine($"Product of Digits of the Number : {product}.");
            Console.ReadLine();
            //Task 4
            int sum1 = 0;
            for (int i = 1; i <= number1; i++)
            {
                if (i % 2 != 0)
                {
                    sum1 += i;
                }
            }
            Console.WriteLine($"Sum of all even number from 1 to {number1} is : {sum1}.");
            Console.ReadLine();
            //Task 5
            int sum2 = 0;
            for (int i = 1; i <= number1; i++)
            {
                if (i % 2 == 0)
                {
                    sum2 += i;
                }
            }
            Console.WriteLine($"Sum of all odd number from 1 to {number1} is : {sum2}.");
            Console.ReadLine();
            //Task 6
            int sum5 = 0;
            for (int i = 1; i <= number1; i++)
            {
                if (i % 5 == 0)
                {
                    sum5 += i;
                }
            }
            Console.WriteLine($"Sum of all  numbers from 1 to {number1} that devide 5 is : {sum5}.");
            Console.ReadLine();
            //Task7
            string[] letters = {"a","b","c","d"};
            Array.Reverse(letters);
            Console.Write($"Reversed array = ");
            foreach (string letter in letters)
            {
                Console.Write($"\"{letter}\",");
            }
            Console.ReadLine();
            //Task 8
            Console.Write($"Please enter lenght of niza1 : ");
            int niza1Lenght= int.Parse(Console.ReadLine());
         
            string[] niza1 = new string[niza1Lenght];
            for(int i=0;i< niza1.Length;i++)
            {
                Console.WriteLine($"Please enter {i} element of niza1 :");
                niza1[i] = Console.ReadLine();
            }
            Console.Write($"Elements of niza 1: ");
            for (int k = 0; k < niza1Lenght; k++)
            {
                Console.Write($"{niza1[k]},");
            }
            Console.Write("\n");
            Console.Write($"Please enter lenght of niza2 :");
            int niza2Lenght = int.Parse(Console.ReadLine());

            string[] niza2 = new string[niza2Lenght];
            for (int i = 0; i < niza1.Length; i++)
            {
                Console.WriteLine($"Please enter {i} element of niza2 :");
                niza2[i] = Console.ReadLine();
            }
            Console.Write($"Elements of niza 2: ");
            for (int k = 0; k < niza1Lenght; k++)
            {
                Console.Write($"{niza2[k]},");
            }
            Console.Write("\n");
            bool equals = niza1.OrderBy(a => a).SequenceEqual(niza2.OrderBy(a => a));
            if (equals)
            {
                Console.WriteLine("Both arrays are equal");
            }
            else
            {
                Console.WriteLine("Both arrays are not equal");
            }
            Console.ReadLine();
            //Task 9
            Console.Write($"Numbers between 1-1000 that devide the sum composed of their digits: ");
            for (int i = 1; i < 1000; i++)
            {
                int sum = i.ToString().Sum(c => c - '0');

                if (i % sum == 0)
                {
                    Console.Write($"{i},");
                }

            }
            Console.ReadLine();
            //Task 10
            Console.Write($"Numbers between 1-1000 that devide the product composed of their digits: ");
            for (int i = 1; i < 1000; i++)
            {

                int product1 = 1;
                int j = i;
                product1 = product1 * (j % 10);
                j = j / 10;
                if (product1 == 0)
                { product1 = 1; }
                //Console.Write($"{product1},");
                if (i % product1 == 0)
                {
                    Console.Write($"{i},");
                }

            }
            Console.ReadLine();
            //Task 11
            int sumDouble = 0;
            for (int i = 10; i <= 99; i++)
            {
                int s= i % 10;
                int f = i / 10;
                if(f>s)
                {
                  sumDouble += i;
                }
            }
            Console.WriteLine($"Sum of all  numbers from 10 to 99 that have first digit grater than the second is: {sumDouble}.");
            Console.ReadLine();
            //Task 12
            for (int i=1;i<=100;i++)
            {
                if (i%3==0&&i%5==0)
                {
                    Console.WriteLine($"FizzBuzz");
                }
                else if (i % 3 == 0 )
                {
                    Console.WriteLine($"Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine($"Buzz");
                }
                else
                {
                    Console.WriteLine($"{i}");
                }
            }


        }
    }
}
