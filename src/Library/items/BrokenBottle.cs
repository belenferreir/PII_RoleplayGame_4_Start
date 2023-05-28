
namespace RoleplayGame.Items
{
    public class BrokenBottle : IAttackItem
    {
        public int AttackPower
        {
            get
            {
                return 15;
            }
        }


        public override string ToString()
        {
            return "BrokenBottle";
        }
    }
}
