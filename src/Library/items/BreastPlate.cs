namespace RoleplayGame.Items
{
    /// <summary>
    /// Coraza. Permite defenderse levemente.
    /// </summary>
    public class BreastPlate : IDefenseItem
    {
        /// <summary>
        /// El poder de defensa.
        /// </summary>
        /// <value>int</value>
        public int DefensePower
        {
            get
            {
                return 20;
            }
        }

        public override string ToString()
        {
            return "BreastPlate";
        }
    }
}