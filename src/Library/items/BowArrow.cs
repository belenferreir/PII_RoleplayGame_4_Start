namespace RoleplayGame.Items
{
    public class BowArrow : IAttackItem
    {
        public int Damage = 0;
        public void GetDamage(Bow bow, Arrow arrow) 
        {
            this.Damage = bow.AttackPower + arrow.AttackPower;
        }
        public int AttackPower
        {
            get
            {
                return (Damage);
            }
        }
        public override string ToString()
        {
            return "BowAndArrow";
        }
    }
}
