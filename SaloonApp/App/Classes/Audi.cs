using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Classes
{
    public class Audi : Auto
    {

        public string Color { get; set; }
        public override AutoType AutoType { get; set; }
        public override Model Model { get; set; }
        public override string Manufacturer { get; set; }
        public override Gas Gas { get; set; }
        public override int Doors { get; set; }
        public override double Consumption { get; set; }
        public override int Price { get; set; }
        public Audi(string color, AutoType autoType,string manufacurer,Gas gas,int doors,double consumption,int price)
        {
            this.Color = color;
            this.AutoType = autoType;
            this.Model = Model.Audi;
            this.Manufacturer = manufacurer;
            this.Gas = gas;
            this.Doors = doors;
            this.Consumption = consumption;
            this.Price = price;


        }
        public string PrintColor()
        {
            return Color;
        }

        public override string PrintCharacteristics()
        {
            return (base.PrintCharacteristics() + PrintColor());
        }


    }
}
