using System;
using jogo_rpg.src.Entities;

namespace jogo_rpg
{
  class Program
  {
    static void Main(string[] args)
    {
      Knight Knight = new Knight("Arus", 23, "Knight");
      WhiteWizard WhiteWizard = new WhiteWizard("Jennica", 23, "White Wizard");
      Ninja Ninja = new Ninja("Wedge", 42, "Ninja");
      BlackWizard BlackWizard = new BlackWizard("Topapa", 42, "Ninja");

      Console.WriteLine(Knight.Name);
      Console.WriteLine("Lv.  " + Knight.Level + " " + Knight.HeroType);
      Console.WriteLine("HP:  " + Knight.HealthPoints() + "/" + Knight.HealthPoints());
      Console.WriteLine("MP:  " + Knight.MagicPoints() + "/" + Knight.MagicPoints());
      Console.WriteLine(Knight.Attack());
      Console.WriteLine("\n");

      Console.WriteLine(Ninja.Name);
      Console.WriteLine("Lv.  " + Ninja.Level + " " + Ninja.HeroType);
      Console.WriteLine("HP:  " + Ninja.HealthPoints() + "/" + Ninja.HealthPoints());
      Console.WriteLine("MP:  " + Ninja.MagicPoints() + "/" + Ninja.MagicPoints());
      Console.WriteLine(Ninja.Attack());
      Console.WriteLine("\n");

      Console.WriteLine(WhiteWizard.Name);
      Console.WriteLine("Lv.  " + WhiteWizard.Level + " " + WhiteWizard.HeroType);
      Console.WriteLine("HP:  " + WhiteWizard.HealthPoints() + "/" + WhiteWizard.HealthPoints());
      Console.WriteLine("MP:  " + WhiteWizard.MagicPoints() + "/" + WhiteWizard.MagicPoints());
      Console.WriteLine(WhiteWizard.Attack(5));
      Console.WriteLine(WhiteWizard.Attack(7));
      Console.WriteLine("\n");

      Console.WriteLine(BlackWizard.Name);
      Console.WriteLine("Lv.  " + BlackWizard.Level + " " + BlackWizard.HeroType);
      Console.WriteLine("HP:  " + BlackWizard.HealthPoints() + "/" + BlackWizard.HealthPoints());
      Console.WriteLine("MP:  " + BlackWizard.MagicPoints() + "/" + BlackWizard.MagicPoints());
      Console.WriteLine(BlackWizard.Attack(5));
      Console.WriteLine(BlackWizard.Attack(7));
      Console.WriteLine("\n");

    }
  }
}
