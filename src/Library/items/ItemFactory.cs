namespace RoleplayGame.Items
{
    /// <summary>
    /// Tipos de elementos
    /// </summary>
    public enum ItemType
    {
        Magic = 1,
        Robes = 2,
        BowArrow = 3,
        Layer = 4,
        Stick = 5,
        Sword = 6,
        BreastPlate = 7,
        BroadSword = 8,
        BrokenBottle = 9,
        Gauntlet = 10

    }

    /// <summary>
    /// Creador de elementos. 
    /// </summary>
    public class ItemFactory
    {
        /// <summary>
        /// Permite crear elementos dado un tipo de elemento.
        /// </summary>
        /// <param name="type">El tipo de elemento</param>
        /// <returns>El elemento</returns>
        public static IItem GetItem(ItemType type)
        {
            switch (type)
            {
                case ItemType.Magic: return new Magic();
                case ItemType.Robes: return new Robes();
                case ItemType.BowArrow: return new BowArrow();
                case ItemType.Layer: return new Layer();
                case ItemType.Stick: return new Stick();
                case ItemType.Sword: return new Sword();
                case ItemType.BreastPlate: return new BreastPlate();
                case ItemType.BroadSword: return new Broadsword();
                case ItemType.BrokenBottle: return new BrokenBottle();
                case ItemType.Gauntlet: return new Gauntlet();

                default: return null;
            }
        }
    }
}