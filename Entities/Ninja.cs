using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_prj_rpg.Entities
{
    public class Ninja : Hero
    {
         public Ninja(string Name, int Level, string HeroType, string HP, string MP)
         {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
        this.HP = HP;
        this.MP = MP;
        }

         public override string Attack(){
            return this.Name + " Atacou com sua estrela ninja";
        }

        public override string Defense(){
            return this.Name + " Escapou com bomba de fumaça";
        }
    }
}