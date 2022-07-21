using System;
using dio_prj_rpg.Entities;
    class Program
    {
        static void Main(string[] args)
        {
            Arus hero = new Arus("Arus", 23, "Knight");
            Arus oponnet = new Arus("Maleficus", 99, "Devil");
            
            Console.WriteLine(hero);
            Console.WriteLine(oponnet);
        }
    }

