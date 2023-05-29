
// No se si esto deberia de existir 

namespace RoleplayGame.Items
{
    /// <summary>
    /// Tipos de elementos
    /// </summary>
    public enum ItemTypeT
    {
        BreastPlate = 1,
        Stick = 2
    }

    /// <summary>
    /// Creador de elementos. 
    /// </summary>
    public class TrollsItem
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
                case ItemType.BreastPlate: return new BreastPlate();
                case ItemType.Stick: return new Stick();

                default: return null;
            }
        }
    }
}