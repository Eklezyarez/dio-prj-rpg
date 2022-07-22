using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_prj_rpg.Entities
{
    public class Wizard : Hero
    {

         public Wizard(string Name, int Level, string HeroType, string HP, string MP)
         {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
        this.HP = HP;
        this.MP = MP;
        }

         public override string Attack(){
            return this.Name + " Lançou magia";
        }

          public override string Defense(){
            return this.Name + " Defendeu com campo de energia";
        }

        public string Attack(int Bonus){
            if (Bonus > 6){
                return this.Name + " Lançou magia forte com bonus de ataque de " + Bonus;
            }else{
                return this.Name + " Lançou magia fraca, com bonus de " + Bonus;
            }

        }
    }
}