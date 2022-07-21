namespace dio_prj_rpg.Entities
{
    public class Hero
    {

        public Hero(string Name, int Level, string HeroType){
            this.Name = Name;
            this.level = Level;
            this.HeroType = HeroType;
        }
        public Hero(){
            
        }
        public string Name;

        public int Level;

        public string HeroType;

        public override string ToString(){
            return this.Name + " " + this.level + " " + this.HeroType;
        }

        public virtual string Attack(){
            return this.Name + " Atracou com sua espada";
        }

    }
}