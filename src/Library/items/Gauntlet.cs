namespace RoleplayGame.Items;
using System.Collections.Generic;
using System;

public class Gauntlet : IAttackItem
{
    public List<Gem> gemas = new List<Gem>();
    public void AddGem(Gem gem)
    {
        if (gemas.Count >= 5)
        {
            Console.WriteLine("Cant do that");
            return ;
        }
        else
        {
            gemas.Add(gem);
        }
    }

    

     public int AttackPower
        {
            get
            {
                int TotalDamage= 0;
                foreach (Gem gem in gemas)
                {
                    TotalDamage += gem.AttackPower;
                }
                return TotalDamage ;
            }
        }


        public override string ToString()
        {
            return "Gauntlet";
        }
}


