namespace jogo_rpg.src.Entities
{
  public class BlackWizard : Hero
  {
    public BlackWizard(string Name, int Level, string HeroType)
    {
      this.Name = Name;
      this.Level = Level;
      this.HeroType = HeroType;
    }
        public override string Attack()
    {
      return this.Name + " Lançou bola de fogo";
        }
        public string Attack(int Bonus){

        if (Bonus > 6){
      return this.Name + " Lançou bola de fogo super efetiva com bonus de " + Bonus;
        }else{
      return this.Name + " Lançou bola de fogo com pouca força " + Bonus;
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