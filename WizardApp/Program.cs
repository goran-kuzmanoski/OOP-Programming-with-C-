using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard[] wizards = new Wizard[3]{
                new Wizard(),
                new Wizard(),
                new Wizard()
            };
            wizards[0].Name = "Goran";
            wizards[0].PowerLevel = 152;
            wizards[0].DateofAdmition = DateTime.Now.AddYears(-1);
            wizards[0].GraduationStatus = false;
            wizards[0].Age = 29;
            wizards[1].Name = "Jovan";
            wizards[1].PowerLevel = 172;
            wizards[1].DateofAdmition = DateTime.Now.AddYears(-2);
            wizards[1].GraduationStatus = false;
            wizards[1].Age = 18;
            wizards[2].Name = "Vladimir";
            wizards[2].PowerLevel = 105;
            wizards[2].DateofAdmition = DateTime.Now.AddYears(-1);
            wizards[2].GraduationStatus = false;
            wizards[2].Age = 13;



            Creature[] creatures = new Creature[2]
            {
                new Creature("Demon",163,12,false),
                new Creature("Witch",150,13,true),
            };
            //creatures[0].Name = "demon";
            //creatures[0].PowerLevel = 120;
            //creatures[0].Tamed = false;
            //creatures[0].Age = 215;
            //creatures[1].Name = "witch";
            //creatures[1].PowerLevel = 161;
            //creatures[1].Tamed = true;
            //creatures[1].Age = 115;

            foreach (Creature creature in creatures)
            {
                if (creature.Tamed == true)
                {
                    Console.WriteLine($"The creature {creature.Name} is already tammed and cannot be dueled");
                }
                else
                {
                    foreach (Wizard wizard in wizards)
                    {
                        if (creature.PowerLevel < wizard.PowerLevel)
                        {
                            //creature.Name = "Worlock";
                            creature.Tamed = true;
                            Console.WriteLine($"The wizard {wizard.Name} wins the duel. The creature {creature.Name} is now tammed!");
                            break;
                        }
                        else
                        {
                            creature.PowerLevel = creature.PowerLevel - wizard.PowerLevel;
                            Console.WriteLine($"The wizard {wizard.Name} did not win the duel. The creature {creature.Name} is not tammed yet!");
                        }
                    }
                }

            }
        }
    }
}
