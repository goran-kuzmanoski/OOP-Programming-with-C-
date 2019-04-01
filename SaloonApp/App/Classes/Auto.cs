using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Classes
{
    abstract public class Auto
    {
        public abstract AutoType AutoType { get; set; }
        public abstract Model Model { get; set; }
        public abstract string Manufacturer { get; set; }
        public abstract Gas Gas { get; set; }
        public abstract int Doors { get; set; }
        public abstract double Consumption { get; set; }
        public abstract int Price { get; set; }
        //public Auto(AutoType autoType, Model model, string manufacturer, Gas gas, int doors, double consumption)
        //{
        //    this.AutoType = autoType;
        //    this.Model = model;
        //    this.Manufacturer = manufacturer;
        //    this.Gas = gas;
        //    this.Doors = doors;
        //    this.Consumption = consumption;
        //}
        public virtual string PrintCharacteristics()
        {
            return ($"Auto type={this.AutoType} ,Model:{this.Model} Manufacturer:{this.Manufacturer}, gas:{this.Gas}");
        }
    }
}
