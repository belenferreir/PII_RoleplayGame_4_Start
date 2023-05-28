namespace RoleplayGame.Items;

public class Axe : IAttackItem
    {
        public int AttackPower
        {
            get
            {
                return 3;
            }
        }


        public override string ToString()
        {
            return "Axe";
        }
    }