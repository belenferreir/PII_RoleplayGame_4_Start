namespace RoleplayGame.Items
{
    public class BowArrow 
    {
        public int Attack(Bow bow, Arrow arrow) 
        {
            return (bow.AttackPower + arrow.AttackPower);
        }
    }
}
