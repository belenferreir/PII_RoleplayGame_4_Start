

namespace RoleplayGame.Items
{
    /// <summary>
    /// Tipos de elementos
    /// </summary>
    public enum ItemTypeW
    {
        Magic = 1,
        Robes = 2,
        Layer = 3
    }

    /// <summary>
    /// Creador de elementos. 
    /// </summary>
    public class WizardItem
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
                case ItemType.Layer: return new Layer();

                default: return null;
            }
        }
    }
}