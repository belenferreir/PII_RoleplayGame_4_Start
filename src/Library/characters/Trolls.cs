using System.Collections.Generic;
using RoleplayGame.Items;

namespace RoleplayGame.Characters
{
    /// <summary>
    /// Personaje Elfo
    /// </summary>
    public class Trolls : Character
    {
        public Trolls(string name)
            : base(name)
        {
            this.Health = 90;
            this.AddItem(new Stick());
            this.AddItem(new BreastPlate());
        }
    }
}