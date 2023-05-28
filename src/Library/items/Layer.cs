namespace RoleplayGame.Items
{
    public class Layer : IDefenseItem
    {
        public int DefensePower
        {
            get
            {
                return 20;
            }
        }

        public override string ToString()
        {
            return "Layer";
        }
    }
}
