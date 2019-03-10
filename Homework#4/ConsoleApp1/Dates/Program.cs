using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create datetime            
            DateTime dt = new DateTime(2018, 02, 21, 18, 50, 23, 230);
           

            //Example how it looks like in the output
            var t = String.Format("{0:t}", dt); // "6:50 PM" ShortTime

            Console.WriteLine(t);
            var d = String.Format("{0:d}", dt); // "21.02.2018"
            Console.WriteLine(d);
            var T = String.Format("{0:T}", dt); // "18:50:23"
            Console.WriteLine(T);
            var D = String.Format("{0:D}", dt); // "Среда, 21 февруари 2018"
            Console.WriteLine(D);
            var f = String.Format("{0:f}", dt); // "Среда, 21 февруари 2018 18:50:23"
            Console.WriteLine(f);            
            var F = String.Format("{0:F}", dt); // "Wednesday, February 21, 2018 6:50:23 PM"
            Console.WriteLine(F);
            Console.WriteLine("--------------");
            var g = String.Format("{0:g}", dt); // "21.02.2018 18:50"
            Console.WriteLine(g);
            var G = String.Format("{0:G}", dt); // "21.02.2018 18:50:23"
            Console.WriteLine(G);
            var m = String.Format("{0:m}", dt); // "21 февруари"
            Console.WriteLine(m);
            var y = String.Format("{0:y}", dt); // "февруари 2018"
            Console.WriteLine(y);
            var r = String.Format("{0:r}", dt); // "Wed 21 Feb 2018 18:50:23 GMT"
            Console.WriteLine(r);
            var s = String.Format("{0:s}", dt); // "2018-02-21T18:50:23"
            Console.WriteLine(s);
            var u = String.Format("{0:u}", dt); // "2018-02-21 18:50:23Z"
            Console.WriteLine(u);

            Console.WriteLine("--------------");

            DateTime TimeNow = DateTime.Now;
            DateTime TimeUtc = DateTime.UtcNow;
            DateTime TimeToday = DateTime.Today;
            Console.WriteLine("Current DateTime: {0} ", TimeNow);  	//"07.03.2019 15:43:41"
            Console.WriteLine("UTC DateTime:     {0} ", TimeUtc); 	//"07.03.2019 14:43:41"
            Console.WriteLine("Today:            {0} ", TimeToday); //"07.03.2019 00:00:00"
            Console.WriteLine();

            DateTime yesterday;
            yesterday = TimeNow.AddDays(-1);
            Console.WriteLine("Yesterday: {0}", yesterday);								//"06.03.2019 15:43:41"
            Console.WriteLine("The day before yesterday {0}", yesterday.TimeOfDay);		//"15:43:41.8862059"
            Console.WriteLine("Minus 2 hours: {0}", TimeNow.AddHours(-2));              //"07.03.2019 13:43:41"

            int mDays = DateTime.DaysInMonth(2016, 2);
            Console.WriteLine("Month Feb, 2016 has {0} days.", mDays);							//"29 days"
            Console.WriteLine("Month Feb, 2018 has {0} days.", DateTime.DaysInMonth(2018, 2));	//"28 days"

        }
    }
}
