using System.Collections.Generic;
using RoleplayGame.Items;

namespace RoleplayGame.Characters
{
    /// <summary>
    /// Personaje Dwarf
    /// </summary>
    public class Dwarf : Character
    {
        public Dwarf(string name)
            : base(name)
        {
            this.Health = 80;
            //this.AddItem(new BowArrow());
            //this.AddItem(new Layer());
        }
    }
}