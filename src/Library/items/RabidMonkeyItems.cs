

namespace RoleplayGame.Items
{
    /// <summary>
    /// Tipos de elementos
    /// </summary>
    public enum ItemTypeR
    {
        BrokenBottle = 1,
        BroadSword = 2
    }

    /// <summary>
    /// Creador de elementos. 
    /// </summary>
    public class Item
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
                case ItemType.BrokenBottle : return new BrokenBottle();
                case ItemType.BroadSword: return new Broadsword();

                default: return null;
            }
        }
    }
}