namespace jogo_rpg.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType)
        {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
        }


        public override int HealthPoints(){
        return this.Level * 10; 
    }
        public override int MagicPoints(){
        return this.Level * 5; 
    }
        
    }
}