namespace jogo_rpg.src.Entities
{
  public class WhiteWizard : Hero
  {
      public WhiteWizard(string Name, int Level, string HeroType)
      {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
      }
    public override string Attack()
    {
      return this.Name + " Lançou Magia";
        }
        public string Attack(int Bonus){

        if (Bonus > 6){
      return this.Name + " Lançou Magia super efetiva com bonus de " + Bonus;
        }else{
      return this.Name + " Lançou Magia com pouca força " + Bonus;
        }
        }

        public override int HealthPoints(){
        return this.Level * 5; 
    }
        public override int MagicPoints(){
        return this.Level * 10; 
    }
  }
}