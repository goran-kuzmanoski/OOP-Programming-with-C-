using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.NewFolder1
{
    public class NormalCar : ICar
    {
        public string MororNumber { get ; set ; }
        public NormalCar()
        {
            MororNumber = this.MororNumber + "-E";
        }
        public NormalCar(string enginenumber)
        {
            MororNumber = enginenumber + "-E";
        }

        public void Refuel()
        {
            Console.WriteLine("Charging with fuel");
        }
    }
}
