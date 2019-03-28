using ConsoleApp2.NewFolder1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ICar> cars = new List<ICar>()
            {
                new NormalCar(enginenumber:"WKJDGSOKF"),
                new ElectricCar(enginenumber:"GOREAKR"),

            };

            cars[0].Refuel();Console.WriteLine(cars[0].MororNumber);
            cars[1].Refuel(); Console.WriteLine(cars[1].MororNumber);
        }
    }
}
