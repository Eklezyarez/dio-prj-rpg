namespace dio_prj_rpg.Entities
{
    public class Hero
    {

        public Hero(string Name, int Level, string HeroType, string HP, string MP){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }
        public Hero(){
            
        }
        public string Name;

        public int Level;

        public string HeroType;

        public string HP;

        public string MP;

        public override string ToString(){
            return this.Name + " " 
            + this.Level + " " 
            + this.HeroType + " "
            + this.HP + " "
            + this.MP;
        }

        public virtual string Attack(){
            return this.Name + " Atacou com sua espada";
        }

        public virtual string Defense(){
            return this.Name + "Defendeu com seu escudo ";
        }

    }
}