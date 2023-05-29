
namespace RoleplayGame.Items
{
    /// <summary>
    /// Tipos de elementos
    /// </summary>
    public enum ItemTypeE
    {
        BowArrow = 1,
        Sword = 2
    }

    /// <summary>
    /// Creador de elementos. 
    /// </summary>
    public class ElfItem
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
                case ItemType.BowArrow: return new BowArrow();
                case ItemType.Sword: return new Sword();

                default: return null;
            }
        }
    }
}