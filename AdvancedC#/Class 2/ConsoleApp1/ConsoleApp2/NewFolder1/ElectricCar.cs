using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.NewFolder1
{
    public class ElectricCar : ICar
    {
        public string MororNumber { get; set; }
        public int BatteryLiveMonths { get; set; }
        public int BatteryDuration { get; set; }
        public ElectricCar()
        {
            MororNumber = this.MororNumber + "-E";
        }
        public ElectricCar(string enginenumber)
        {
            MororNumber = enginenumber + "-E";
        }

        public void Refuel()
        {
            Console.WriteLine("Charging battery");
        }
    }
}
