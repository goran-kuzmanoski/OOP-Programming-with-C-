using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------TASK 10-------------");

            Console.WriteLine("Please choose difficulty level: easy, normal or hard!");
            var level = Console.ReadLine();
            int countInputGuess = 0;
            bool userWin = false;


            if (level == "easy")
            {
                int end = 100;
                int numberToGuess = RandomNumber(0, end);
                int numberOfTries = 9;
                do
                { 
                    Console.WriteLine($"\nPlease enter your guess between 0 and {end}!");
                    int userInput;
                    bool inputGuess = int.TryParse(Console.ReadLine(), out userInput);
                    countInputGuess++;
                    Console.Write($"{countInputGuess} try!");
                    if (userInput > (numberToGuess + 8))
                    {
                        Console.WriteLine($"Your guess is far to high, number entered: {userInput}.");
                    }
                    else if (userInput < (numberToGuess + 8) && userInput > (numberToGuess))
                    {
                        Console.WriteLine($"Your guess is a little bit higher, number entered :{userInput}.");
                    }
                    else if (userInput == numberToGuess)
                    {
                        userWin = true;
                        if (countInputGuess == 1)
                        {
                            Console.WriteLine($"Lucky guess.");

                        }
                        else if (countInputGuess > numberOfTries)
                        {
                            Console.WriteLine($"Try again.");
                        }
                        else
                        {
                            Console.WriteLine($"Nailed it. number entered: {userInput}.");
                        }
                        Console.WriteLine("Press 1 to start a new game, press 2 to quit game");
                        var result = Console.ReadLine();
                        if (result == "1")
                        {
                            userWin = false;
                            countInputGuess = 0;
                            numberToGuess = RandomNumber(0, 100);
                        }
                        if (result == "2")
                        {
                            Console.WriteLine("Thank you for playing.");
                            break;
                        }

                    }
                    else if (userInput < (numberToGuess - 8))
                    {
                        Console.WriteLine($"Your guess is far to low, number entered: {userInput}.");
                    }
                    else if (userInput > (numberToGuess - 8) && userInput < (numberToGuess))
                    {
                        Console.WriteLine($"Your guess is a little bit lower, number entered :{userInput}.");
                    }
                    if(countInputGuess==numberOfTries)
                    {
                        Console.WriteLine("Maximum number of tries reached.");
                        Console.WriteLine("Press 1 to start a new game, press 2 to quit game");
                        var result = Console.ReadLine();
                        if (result == "1")
                        {
                            userWin = false;
                            countInputGuess = 0;
                            numberToGuess = RandomNumber(0, end);
                        }
                        if (result == "2")
                        {
                            Console.WriteLine("Thank you for playing.");
                            break;
                        }
                    }

                    if (!inputGuess)
                    {
                        Console.WriteLine("Not a valid number! You also lost an attempt.");
                    }

                }
                while (countInputGuess <= numberOfTries && userWin != true);
                
            }
            if (level == "normal")
            {
                int end = 500;
                int numberToGuess = RandomNumber(0, end);
                int numberOfTries = 7;
                do
                {
                    Console.WriteLine($"\nPlease enter your guess between 0 and {end}!");
                    int userInput;
                    bool inputGuess = int.TryParse(Console.ReadLine(), out userInput);
                    countInputGuess++;
                    Console.Write($"{countInputGuess} try!");
                    if (userInput > (numberToGuess + 8))
                    {
                        Console.WriteLine($"Your guess is far to high, number entered: {userInput}.");
                    }
                    else if (userInput < (numberToGuess + 8) && userInput > (numberToGuess))
                    {
                        Console.WriteLine($"Your guess is a little bit higher, number entered :{userInput}.");
                    }
                    else if (userInput == numberToGuess)
                    {
                        userWin = true;
                        if (countInputGuess == 1)
                        {
                            Console.WriteLine($"Lucky guess.");

                        }
                        else if (countInputGuess > numberOfTries)
                        {
                            Console.WriteLine($"Try again.");
                        }
                        else
                        {
                            Console.WriteLine($"Nailed it. number entered: {userInput}.");
                        }
                        Console.WriteLine("Press 1 to start a new game, press 2 to quit game");
                        var result = Console.ReadLine();
                        if (result == "1")
                        {
                            userWin = false;
                            countInputGuess = 0;
                            numberToGuess = RandomNumber(0, 100);
                        }
                        if (result == "2")
                        {
                            Console.WriteLine("Thank you for playing.");
                            break;
                        }

                    }
                    else if (userInput < (numberToGuess - 8))
                    {
                        Console.WriteLine($"Your guess is far to low, number entered: {userInput}.");
                    }
                    else if (userInput > (numberToGuess - 8) && userInput < (numberToGuess))
                    {
                        Console.WriteLine($"Your guess is a little bit lower, number entered :{userInput}.");
                    }
                    if (countInputGuess == numberOfTries)
                    {
                        Console.WriteLine("Maximum number of tries reached.");
                        Console.WriteLine("Press 1 to start a new game, press 2 to quit game");
                        var result = Console.ReadLine();
                        if (result == "1")
                        {
                            userWin = false;
                            countInputGuess = 0;
                            numberToGuess = RandomNumber(0, end);
                        }
                        if (result == "2")
                        {
                            Console.WriteLine("Thank you for playing.");
                            break;
                        }
                    }

                    if (!inputGuess)
                    {
                        Console.WriteLine("Not a valid number! You also lost an attempt.");
                    }

                }
                while (countInputGuess <= numberOfTries && userWin != true);

            }
            if (level == "hard")
            {
                int end = 1000;
                int numberToGuess = RandomNumber(0, end);
                int numberOfTries = 5;
                do
                {
                    Console.WriteLine($"\nPlease enter your guess between 0 and {end}!");
                    int userInput;
                    bool inputGuess = int.TryParse(Console.ReadLine(), out userInput);
                    countInputGuess++;
                    Console.Write($"{countInputGuess} try!");
                    if (userInput > (numberToGuess + 8))
                    {
                        Console.WriteLine($"Your guess is far to high, number entered: {userInput}.");
                    }
                    else if (userInput < (numberToGuess + 8) && userInput > (numberToGuess))
                    {
                        Console.WriteLine($"Your guess is a little bit higher, number entered :{userInput}.");
                    }
                    else if (userInput == numberToGuess)
                    {
                        userWin = true;
                        if (countInputGuess == 1)
                        {
                            Console.WriteLine($"Lucky guess.");

                        }
                        else if (countInputGuess > numberOfTries)
                        {
                            Console.WriteLine($"Try again.");
                        }
                        else
                        {
                            Console.WriteLine($"Nailed it. number entered: {userInput}.");
                        }
                        Console.WriteLine("Press 1 to start a new game, press 2 to quit game");
                        var result = Console.ReadLine();
                        if (result == "1")
                        {
                            userWin = false;
                            countInputGuess = 0;
                            numberToGuess = RandomNumber(0, 100);
                        }
                        if (result == "2")
                        {
                            Console.WriteLine("Thank you for playing.");
                            break;
                        }

                    }
                    else if (userInput < (numberToGuess - 8))
                    {
                        Console.WriteLine($"Your guess is far to low, number entered: {userInput}.");
                    }
                    else if (userInput > (numberToGuess - 8) && userInput < (numberToGuess))
                    {
                        Console.WriteLine($"Your guess is a little bit lower, number entered :{userInput}.");
                    }
                    if (countInputGuess == numberOfTries)
                    {
                        Console.WriteLine("Maximum number of tries reached.");
                        Console.WriteLine("Press 1 to start a new game, press 2 to quit game");
                        var result = Console.ReadLine();
                        if (result == "1")
                        {
                            userWin = false;
                            countInputGuess = 0;
                            numberToGuess = RandomNumber(0, end);
                        }
                        if (result == "2")
                        {
                            Console.WriteLine("Thank you for playing.");
                            break;
                        }
                    }

                    if (!inputGuess)
                    {
                        Console.WriteLine("Not a valid number! You also lost an attempt.");
                    }

                }
                while (countInputGuess <= numberOfTries && userWin != true);

            }

        }
        static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
