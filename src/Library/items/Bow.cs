
namespace RoleplayGame.Items
{
    public class Bow : IAttackItem
    {
        public int AttackPower
        {
            get
            {
                return 20;
            }
        }


        public override string ToString()
        {
            return "Sword";
        }
    }
}
