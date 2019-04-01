using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Classes
{
    public class Opel : Auto
    {
        public override AutoType AutoType { get; set; }
        public override Model Model { get; set; }
        public override string Manufacturer { get; set; }
        public override Gas Gas { get; set; }
        public override int Doors { get; set; }
        public override double Consumption { get; set; }
        public string Producer { get; set; }
        public override int Price { get; set; }

        public override string PrintCharacteristics()
        {
            return (base.PrintCharacteristics() + this.Producer);
        }

    }
}
