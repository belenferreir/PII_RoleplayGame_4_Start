namespace RoleplayGame.Items
{
    public class Bow : IAttackItem
    {
        public int AttackPower
        {
            get
            {
                return 13;
            }
        }


        public override string ToString()
        {
            return "Bow";
        }
    }
}