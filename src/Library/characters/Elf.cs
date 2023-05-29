using System.Collections.Generic;
using RoleplayGame.Items;

namespace RoleplayGame.Characters
{
    /// <summary>
    /// Personaje Elfo
    /// </summary>
    public class Elf : Character
    {
        public Elf(string name)
            : base(name)
        {
            this.Health = 100;
            //this.AddItem(new Robes());
            //this.AddItem(new BrokenBottle());
        }
    }
}