using System;
using dio_prj_rpg.Entities;
    class Program
    {
        static void Main(string[] args)
        {
            Hero arus = new Hero("Arus", 23, "Knight");
            Hero wizard = new Hero("Jennica", 23, "White Wizard");

            Console.WriteLine(wizard.Attack());
           
        }
    }

