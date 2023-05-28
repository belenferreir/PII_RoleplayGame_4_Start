
namespace RoleplayGame.Items
{
    public class Arrow : IAttackItem
    {
        public int AttackPower
        {
            get
            {
                return 7;
            }
        }


        public override string ToString()
        {
            return "Arrow";
        }
    }
}