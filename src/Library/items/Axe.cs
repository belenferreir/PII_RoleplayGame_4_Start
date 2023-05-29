namespace RoleplayGame.Items
{
    public class Axe : IAttackItem
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
            return "Axe";
        }
    }

}