namespace RoleplayGame.Characters
{
    /// <summary>
    /// Tipos de personajes
    /// </summary>
    public enum CharacterType
    {
        Elf = 1,
        Wizard = 2,
        Trolls = 3,
        Dwarf = 4,
        RabidMonkey=5
    }

    /// <summary>
    /// Crea objetos de tipo Personaje
    /// </summary>
    public class CharacterFactory
    {
        /// <summary>
        /// Crea un personaje dado un tipo de personaje y un nombre
        /// </summary>
        public static Character GetCharacter(CharacterType type, string name)
        {
            switch (type)
            {
                case CharacterType.Elf: return new Elf(name);
                case CharacterType.Wizard: return new Wizard(name);
                case CharacterType.Trolls: return new Trolls(name);
                case CharacterType.Dwarf: return new Dwarf(name);
                case CharacterType.RabidMonkey: return new RabidMonkey(name);

                default: throw new System.Exception($"Invalid character {type}");
            }
        }
    }
}