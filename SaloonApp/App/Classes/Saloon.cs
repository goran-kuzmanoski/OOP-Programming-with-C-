using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Classes
{
       public class Saloon
    {
        public string Address { get; set; }
        public List<Auto> Autos { get; set; }
        public Saloon(string address,List <Auto> autos)
        {
            this.Address = address;
            this.Autos = autos;

        }
        public void Buy(int money)
        {
            Console.WriteLine($"With this {money} money you can buy:");
            foreach (Auto Auto in Autos)
            {
                if (Auto.Price < money)
                {
                    Console.Write(Auto.Model);
                }
            }
        }
    }
}
