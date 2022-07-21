using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_prj_rpg.Entities
{
    public class Wizard : Hero
    {
         public override string Attack(){
            return this.Name + " Atracou com sua espada";
        }
    }
}