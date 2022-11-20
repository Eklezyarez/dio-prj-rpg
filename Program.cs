using System;
using dio_prj_rpg.Entities;
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 42, "Knight", "469 / 749", "72 / 72");
            Wizard jenica = new Wizard("Jennica", 42, "White Wizard", "325 / 601", "474 / 482");
            Ninja wedge = new Ninja("Wedge", 42, "Ninja", "292 / 574", "89 / 89");
            Wizard topapa = new Wizard("Topapa", 23, "Black Wizard", "325 / 601", "474 / 482");

            Console.WriteLine("Personagens");
            Console.WriteLine("Nome \t" + "Level \t" + "Tipo \t\t" + "HP \t\t" + "MP \t");
            Console.WriteLine(arus.Name + "\t" + arus.Level + "\t" + arus.HeroType + "\t\t" + arus.HP + "\t" + arus.MP );
            Console.WriteLine(jenica.Name + "\t" + jenica.Level + "\t" + jenica.HeroType + "\t" + jenica.HP + "\t" + jenica.MP );
            Console.WriteLine(wedge.Name + "\t" + wedge.Level + "\t" + wedge.HeroType + "\t\t" + wedge.HP + "\t" + wedge.MP );
            Console.WriteLine(topapa.Name + "\t" + topapa.Level + "\t" + topapa.HeroType + "\t" + topapa.HP + "\t" + topapa.MP );
          
            
            Console.WriteLine("\n\n--Batalha 1--\n");
            Console.WriteLine("\n*****Jenica vs Arus*****\n");
            Console.WriteLine(arus.Attack());
            Console.WriteLine(jenica.Attack(1));
            Console.WriteLine(jenica.Attack(7));
            Console.WriteLine(arus.Defense());

            Console.WriteLine("\n\n--Batalha 2--\n");
            Console.WriteLine("\n*****Wedge vs Topapa*****\n");
            Console.WriteLine(topapa.Attack());
            Console.WriteLine(wedge.Attack());
            Console.WriteLine(topapa.Defense());
         
                    
        }
    }
