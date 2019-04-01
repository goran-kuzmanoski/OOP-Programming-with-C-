using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Classes;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Auto> autos1 = new List<Auto>()
            {
            new Audi("red", AutoType.travel, "Germany", Gas.diesel, 3, 8.5, 25000),
            new Audi("silver", AutoType.travel, "Germany", Gas.petrol, 5, 5.5, 18000),
            new Audi("black", AutoType.travel, "Germany", Gas.petrol, 5, 7.5, 35000)
            };
            Saloon saloonAudi = new Saloon("Boul Jane Sandaski 31", autos1);
            Audi(autos1)
        }
    }
}
