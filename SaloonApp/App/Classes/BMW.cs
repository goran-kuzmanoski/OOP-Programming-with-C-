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
