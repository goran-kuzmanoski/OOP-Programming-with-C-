using System.Collections.Generic;
using LinqExercise.Services;
using LinqExercise.Models;
using System;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = PersonService.GetAllPeople();

            var dogs = DogService.GetAllDogs();

            Person a = people.FirstOrDefault(x => x.FirstName == "Cristofer");
            if (a != null)
            {
                a.Dogs = new List<Dog>();
                Dog jack = dogs.FirstOrDefault(x => x.Name == "Jack");
                Dog ellie = dogs.FirstOrDefault(x => x.Name == "Ellie");
                Dog tilly = dogs.FirstOrDefault(x => x.Name == "Tilly");
                Dog hank = dogs.FirstOrDefault(x => x.Name == "Hank");
                a.Dogs.Add(jack);
                a.Dogs.Add(ellie);
                a.Dogs.Add(tilly);
                // a.Dogs.Add(hank);
            }
            //foreach (var dog in a.Dogs)
            //{
            //    Console.WriteLine(dog.Name);
            //}


            Person b = people.FirstOrDefault(x => x.FirstName == "Freddy");
            if (b != null)
            {
                b.Dogs = new List<Dog>();
                Dog oscar = dogs.FirstOrDefault(x => x.Name == "Oscar");
                Dog toby = dogs.FirstOrDefault(x => x.Name == "Toby");
                Dog chanel = dogs.FirstOrDefault(x => x.Name == "Chanel");
                Dog bo = dogs.FirstOrDefault(x => x.Name == "Bo");
                Dog scout = dogs.FirstOrDefault(x => x.Name == "Scout");

                b.Dogs.Add(oscar);
                b.Dogs.Add(toby);
                b.Dogs.Add(chanel);
                b.Dogs.Add(bo);
                b.Dogs.Add(scout);
                //b.PrintAllDogs();
            }

            Person c = people.FirstOrDefault(x => x.FirstName == "Erin");
            if (c != null)
            {
                c.Dogs = new List<Dog>();
                Dog trixie = dogs.FirstOrDefault(x => x.Name == "Trixie");
                Dog archie = dogs.FirstOrDefault(x => x.Name == "Archie");
                Dog max = dogs.FirstOrDefault(x => x.Name == "Max");
                c.Dogs.Add(trixie);
                c.Dogs.Add(archie);
                c.Dogs.Add(max);
                // c.PrintAllDogs();
            }
            Person ameliaFromList = people.FirstOrDefault(x => x.FirstName == "Amelia");
            if (ameliaFromList != null)
            {
                ameliaFromList.Dogs = new List<Dog>();
                Dog abby = dogs.FirstOrDefault(x => x.Name == "Abby");
                Dog shadow = dogs.FirstOrDefault(x => x.Name == "Shadow");
                ameliaFromList.Dogs.Add(abby);
                ameliaFromList.Dogs.Add(shadow);
                //ameliaFromList.PrintAllDogs();
            }

            Person larryFromList = people.FirstOrDefault(x => x.FirstName == "Larry");
            if (larryFromList != null)
            {
                larryFromList.Dogs = new List<Dog>();
                Dog zoe = dogs.FirstOrDefault(x => x.Name == "Zoe");
                Dog ollie = dogs.FirstOrDefault(x => x.Name == "Ollie");
                larryFromList.Dogs.Add(zoe);
                larryFromList.Dogs.Add(ollie);
                //larryFromList.PrintAllDogs();
            }

            Person ericaFromList = people.FirstOrDefault(x => x.FirstName == "Erika");
            if (ericaFromList != null)
            {
                ericaFromList.Dogs = new List<Dog>();
                ericaFromList.Dogs.AddRange(dogs.Where(x => x.Race == Race.Retriever));
                //ericaFromList.PrintAllDogs();
            }
            if (c != null)
            {
                c.Dogs.AddRange(dogs.Where(x => x.Name == "Chet"));
                c.Dogs.AddRange(dogs.Where(x => x.Name == "Ava"));
            }
            Person august = people.FirstOrDefault(x => x.FirstName == "August");
            if (august != null)
            {
                august.Dogs = new List<Dog>();
                august.Dogs.AddRange(dogs.Where(x => x.Name == "Diesel"));
                august.Dogs.AddRange(dogs.Where(x => x.Name == "Rigby"));
            }

            #region Exercises

            var excercise1 = people
                .Where(x => x.FirstName.ToLower().StartsWith("r"))
                .OrderByDescending(x => x.Age)
                .ToList();

            //foreach (var perosns in excercise1)
            //{
            //    Console.WriteLine(perosns.FirstName);
            //}

            var browndogs = dogs
                .Where(x => x.Color == Color.Brown)
                .Where(x => x.Age >= 3)
                .OrderBy(x => x.Age)
                .ToList();
            foreach (var browndog in browndogs)
            {
                //Console.WriteLine(browndog.Name + " " + browndog.Age);
            }

            var personsWithDogs = people
                .Where(x => x.Dogs != null && x.Dogs.Count() > 2)
                .OrderByDescending(x => x.FirstName)
                .ToList();
            foreach (var person1 in personsWithDogs)
            {
               // Console.WriteLine(person1.FirstName);
            }
            var personsWithOneDog = people
                .Where(x => x.Dogs != null)
                .Where(x => x.Dogs.All(y => y.Race == x.Dogs[0].Race))
                .ToList();

            var personsWithOneDogBetter = people
                .Where(x => x.Dogs != null)
                .Where(x => x.Dogs.Select(f => f.Race).Distinct().Count() == 1)
                .ToList();

            foreach (var person1 in personsWithOneDog)
            {
                //Console.WriteLine(person1.FirstName);
            }

            var Freddysdogs = people
                 .FirstOrDefault(x => x.FirstName.Equals("Freddy"));

            var result5 = Freddysdogs.Dogs.Where(x => x.Age > 1).GroupBy(x => x.Race).ToList();
            foreach (var groupOfDogs in result5)
            {
                Console.WriteLine($"Race:{groupOfDogs.Key}");

                foreach(var dog in groupOfDogs)
                {
                    Console.WriteLine(dog.Name);
                }
            }

            //var result6 = people.Reverse());
            //var count = people.Count;
            //var result6=people.Skip(count - 10).GroupBy(x => x.Age).ToList();
            // var last10People = people.OrderByDescending(x => x.Age).Take(10).ToList();
            var grouper = people.OrderByDescending(x => x.Age).GroupBy(x => x.Age).Take(10).ToList();
                    

            foreach (var groupOfDogs in grouper)
            {
                Console.WriteLine($"Age:{groupOfDogs.Key}");

                foreach (var person in groupOfDogs)
                {
                    Console.WriteLine(person.FirstName);
                }
            }

            // 6. Find and print last 10 persons grouped by their age.


            // 7. Find and print all dogs names from Cristofer, Freddy, Erin and Amelia, grouped by color and ordered by name - ASCENDING ORDER.
            // 8. Find and persons that have same dogs races and order them by name length ASCENDING, then by age DESCENDING.
            // 9. Find the last dog of Amelia and print all dogs form other persons older than Amelia, ordered by dogs age DESCENDING.
            // 10. Find all developers older than 20 with more than 1 dog that contains letter 'e' in the name and print their names and job positions.

            #endregion
        }
    }
}