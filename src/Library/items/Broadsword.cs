namespace RoleplayGame.Items
{
    public class Broadsword : IAttackItem
    {
        public int AttackPower
        {
            get
            {
                return 30;
            }
        }


        public override string ToString()
        {
            return "Broadsword";
        }
    }
}