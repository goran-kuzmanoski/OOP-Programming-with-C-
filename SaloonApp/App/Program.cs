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
            new Audi("black", AutoType.cargo, "Germany", Gas.petrol, 5, 7.5, 35000)
            };
            Saloon saloonAudi = new Saloon("Boul Jane Sandaski BB", autos1);

            saloonAudi.Buy(19000, 36000);

            List<Auto> autos2 = new List<Auto>()
            {
            new BMW(AutoType.travel,"Germany",Gas.diesel,3,5.2,17000,true),
            new BMW(AutoType.cargo,"Germany",Gas.petrol,5,5.2,25000,true),
            new BMW(AutoType.travel,"Germany",Gas.diesel,5,5.2,22000,false),
            };
            Saloon saloonBMW = new Saloon("Krste misirkov", autos2);
            saloonBMW.Buy(18000, 22000);
        }
    }
}
