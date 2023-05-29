
namespace RoleplayGame.Items
{
    /// <summary>
    /// Tipos de elementos
    /// </summary>
    public enum ItemTypeD
    {
        Axe = 1,
        Gauntlet = 2
    }

    /// <summary>
    /// Creador de elementos. 
    /// </summary>
    public class DwarfItem
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
                case ItemType.Axe : return new Axe();
                case ItemType.Gauntlet: return new Gauntlet();

                default: return null;
            }
        }
    }
}