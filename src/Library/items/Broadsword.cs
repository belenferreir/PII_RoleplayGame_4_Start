namespace RoleplayGame.Items
{
    public class Broadsword : IAttackItem
    {
        public int AttackPower
        {
            get
            {
                return 31;
            }
        }


        public override string ToString()
        {
            return "Broadsword";
        }
    }
}