using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Creature
    {
        
        public string Name { get; set; }
        public int PowerLevel { get; set; }
        public int Age { get; set; }
        public bool Tamed { get; set; }

        public Creature(string name, int power, int age, bool tamed)
        {
            this.Name = name;
            this.PowerLevel = power;
            this.Age = age;
            this.Tamed = tamed;
        }

       
    }
}
