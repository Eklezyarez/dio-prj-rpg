namespace dio_prj_rpg.Entities
{
    public class Arus
    {

        public Arus(string Name, int Level, string HeroType){
            this.Name = Name;
            this.level = Level;
            this.HeroType = HeroType;
        }
        public Arus(){
            
        }
        public string Name;

        public int Level;

        public string HeroType;

        public override string ToString(){
            return this.Name + " " + this.level + " " + this.HeroType;
        }

        public string Attack(){
            return this.name
        }

    }
}