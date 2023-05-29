
namespace RoleplayGame.Items
{
    public class BrokenBottle : IAttackItem
    {
        public int AttackPower
        {
            get
            {
                return 28;
            }
        }


        public override string ToString()
        {
            return "BrokenBottle";
        }
    }
}
