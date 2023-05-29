using System;
using System.Collections.Generic;

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
        Gauntlet = 10,
        Axe = 11

    }

     public enum AttackItem
    {
        Magic = 1,
        Axe = 2,
        Sword = 3,
        BowArrow = 4,
        Gauntlet = 5,
        BrokenBottle = 6,
        BroadSword = 7,
        Stick = 8,
    }

    public enum DefenseItem
    {
        Robes = 1,
        Layer = 2,
        Breastplate = 3,
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

        public static IItem GetRandomItem()
        {
            Random random = new Random();
            Array values = Enum.GetValues(typeof(ItemType));
            ItemType randomItemType = (ItemType)values.GetValue(random.Next(values.Length));
            return GetItem(randomItemType);
        }



        public static IAttackItem GetAttackItem(AttackItem type)
        {
            switch (type)
            {
                case AttackItem.Magic: return new Magic();
                case AttackItem.Axe: return new Axe();
                case AttackItem.Sword: return new Sword();
                case AttackItem.BowArrow: return new BowArrow();
                case AttackItem.BrokenBottle: return new BrokenBottle();
                case AttackItem.Gauntlet: return new Gauntlet();
                case AttackItem.Stick: return new Stick();

                default: return null;
            }
        }

        public static IDefenseItem GetDefenseItem(DefenseItem type)
        {
            switch (type)
            {
                case DefenseItem.Robes: return new Robes();
                case DefenseItem.Layer: return new Layer();
                case DefenseItem.Breastplate: return new BreastPlate();

                default: return null;
            }
        }

         public static IItem GetRandomItem(List<IItem> items)
        {
            if (items.Count >= 1)
            {
                if (items[0] is IDefenseItem)
                {
                    // delay
                    Random random = new Random();
                    Array values = Enum.GetValues(typeof(AttackItem));
                    AttackItem randomItemType = (AttackItem)values.GetValue(random.Next(values.Length));
                    return GetAttackItem(randomItemType);
                }
                else
                {
                    Random random = new Random();
                    Array values = Enum.GetValues(typeof(DefenseItem));
                    DefenseItem randomItemType = (DefenseItem)values.GetValue(random.Next(values.Length));
                    return GetDefenseItem(randomItemType);
                }
            }
            else
            {
                Random random = new Random();
                Array values = Enum.GetValues(typeof(ItemType));
                ItemType randomItemType = (ItemType)values.GetValue(random.Next(values.Length));
                return GetItem(randomItemType);
            }
        }
    }
}