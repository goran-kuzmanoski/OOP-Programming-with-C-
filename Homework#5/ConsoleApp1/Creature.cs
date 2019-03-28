using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Creature
    {
        private string v1;
        private int v2;
        private bool v3;

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
