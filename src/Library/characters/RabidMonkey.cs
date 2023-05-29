using System.Collections.Generic;
using RoleplayGame.Items;

namespace RoleplayGame.Characters
{
    /// <summary>
    /// Personaje Elfo
    /// </summary>
    public class RabidMonkey : Character
    {
        public RabidMonkey(string name)
            : base(name)
        {
            this.Health = 100;
            //this.AddItem(new Broadsword());
            //this.AddItem(new BrokenBottle());
        }
    }
}