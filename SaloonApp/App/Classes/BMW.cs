using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Classes
{
    public class BMW : Auto
    {
        public override AutoType AutoType { get; set; }
        public override Model Model { get; set; }
        public override string Manufacturer { get; set; }
        public override Gas Gas { get; set; }
        public override int Doors { get; set; }
        public override double Consumption { get; set; }
        public override int Price { get; set; }
        public bool SunRoof { get; set; }

        public BMW(AutoType autoType, string manufacurer, Gas gas, int doors, double consumption, int price, bool sunroof)
        {
            this.AutoType = autoType;
            this.Model = Model.BMW;
            this.Manufacturer = manufacurer;
            this.Gas = gas;
            this.Doors = doors;
            this.Consumption = consumption;
            this.Price = price;
            this.SunRoof = sunroof;

        }
        public override string PrintCharacteristics()
        {
            if (SunRoof == true)
            {
                return base.PrintCharacteristics() + "Auto has sunroof";
            }
            else
            {
                return base.PrintCharacteristics() + "Auto has no sunroof";
            }
        }
    }
}
