namespace jogo_rpg.src.Entities
{
  public abstract class Hero
  {
    public Hero(string Name, int Level, string HeroType)
    {
      this.Name = Name;
      this.Level = Level;
      this.HeroType = HeroType;
    }

    public Hero (){

    }

    public string Name;
    public int Level;
    public string HeroType;

    public override string ToString()
    {
      return this.Name + " " + this.Level + " " + this.HeroType;
    }

    public virtual string Attack()
    {
      return this.Name + " Atacou com sua espada";
    }

    public virtual int HealthPoints(){
      return this.Level * 5;
    }

      public virtual int MagicPoints(){
      return this.Level * 5;
    }

  }
}