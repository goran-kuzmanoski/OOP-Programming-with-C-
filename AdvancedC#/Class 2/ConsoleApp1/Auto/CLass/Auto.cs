using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto.CLass
{
    public abstract class Auto
    {
        public enum AutoType { patnicko, tovarno }
        public enum Model { Opel, Audi, BMW }
        public string Manufacturer { get; set; }
        public enum Gas { diesel, petrol }
        public int Doors { get; set; }
        public double Consumption { get; set; }
        public virtual void PrintCharacteristics()
            {
           
            }


    }
}
