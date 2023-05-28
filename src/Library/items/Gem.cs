namespace RoleplayGame.Items;

public class Gem: IAttackItem
{
    public int AttackPower
    {
        get
        {
            return 10;
        }
    }


    public override string ToString()
    {
        return "Gem";
    }
}
 
