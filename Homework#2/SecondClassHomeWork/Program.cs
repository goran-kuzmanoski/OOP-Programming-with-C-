using System;

namespace SecondClassHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {

            //Task #1
            Console.WriteLine("What is behind door number: 1, 2, 3");
            var input = Console.ReadLine();
            int numInput;
            bool parseResult = int.TryParse(input, out numInput);

            if (!parseResult)
            {
                Console.WriteLine($"You entered '{input}' which is not a valid integer");
                return;
            }

            switch (numInput)
            {
                case 1:
                    Console.WriteLine("You got a new car");
                    break;
                case 2:
                    Console.WriteLine("You got a new plane");
                    break;
                case 3:
                    Console.WriteLine("You got a new bike");
                    break;
                default:
                    Console.WriteLine($"Door #{numInput} does not exist");
                    break;
            }

            //Task #2
            Console.WriteLine("Enter four numbers!");
            Console.WriteLine("Please enter first number:");
            var first = Console.ReadLine();
            double firstInput;
            bool parseResult1 = double.TryParse(first, out firstInput);

            if (!parseResult1)
            {
                Console.WriteLine($"You entered '{first}' which is not a valid number");
                return;
            }

            Console.WriteLine("Please enter second number");
            var second = Console.ReadLine();
            double secondInput;
            bool parseResult2 = double.TryParse(second, out secondInput);

            if (!parseResult2)
            {
                Console.WriteLine($"You entered '{second}' which is not a valid number");
            }

            Console.WriteLine("Please enter Third number");
            var third = Console.ReadLine();
            double thirdInput;
            bool parseResult3 = double.TryParse(third, out thirdInput);

            if (!parseResult3)
            {
                Console.WriteLine($"You entered '{third}' which is not a valid number");
            }

            Console.WriteLine("Please enter fourth number");
            var fourth = Console.ReadLine();
            double fourthInput;
            bool parseResult4 = double.TryParse(fourth, out fourthInput);

            if (!parseResult4)
            {
                Console.WriteLine($"You entered '{fourth}' which is not a valid number");
            }
            double average = (firstInput + secondInput + thirdInput + fourthInput) / 4;
            Console.WriteLine($"The average of {first},{second},{third},{fourth} is {average}");

            //Bonus Task

            Console.WriteLine("Please enter the temperature in centigrade:");
            var centigrade = Console.ReadLine();
            double temperature;
            bool parseTemperature = double.TryParse(centigrade, out temperature);

            if (temperature < 0) 
            {
                Console.WriteLine("Freezing weather");
            }
            else if (temperature>=0 && temperature <= 10) 
            {
                Console.WriteLine("Very Cold weather");
            }
            else if (temperature > 10 && temperature <= 20) 
            {
                Console.WriteLine("Cold weather");
            }
            else if (temperature > 20 && temperature <= 30) 
            {
                Console.WriteLine("Normal Temp");
            }
            else if (temperature > 30 && temperature < 40) 
            {
                Console.WriteLine("Its Hot");
            }
            else if (temperature >= 40)
            {
                Console.WriteLine("Its Very Hot");
            }
        }
    }
}
