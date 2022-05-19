namespace jogo_rpg.src.Entities
{
  public class Ninja : Hero
  {
    public Ninja(string Name, int Level, string HeroType)
    {
      this.Name = Name;
      this.Level = Level;
      this.HeroType = HeroType;
    }

    public override string Attack()
    {
      return this.Name + " Fez um ataque furtivo" ;
    }

    public override int HealthPoints(){
        return this.Level * 7; 
    }
        public override int MagicPoints(){
        return this.Level * 7; 
    }
  }
}