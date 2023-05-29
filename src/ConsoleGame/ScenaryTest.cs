using System;
using System.Collections.Generic;
using RoleplayGame.Encounters;
using RoleplayGame.Characters;
using RoleplayGame.Items;
using RoleplayGame.Scenarios;

namespace Program
{

    public class ScenaryTest : IScenario
    {
        
        private List<Character> characters = new List<Character>();
        public void Setup()
        {
            Wizard wizard = new Wizard("Wizard");
            RabidMonkey rabidMonkey = new RabidMonkey("RabidMoonkey");
            Elf elf = new Elf("Elf");
            Dwarf dwarf = new Dwarf("Dwarf");
            Trolls troll = new Trolls("Troll");

            characters.Add(rabidMonkey);
            characters.Add(troll);
            characters.Add(wizard);
            characters.Add(elf);
            characters.Add(dwarf);

            foreach (Character character in characters)
            {
                character.AddItem(ItemFactory.GetRandomItem(character.Items));
                character.AddItem(ItemFactory.GetRandomItem(character.Items));
            }
        }

        public void Run()
        {
            AttackEncounter encounterOne = EncounterFactory.GetEncounter(EncounterType.Attack, characters[0], characters[1]) as AttackEncounter;
            encounterOne.Reporter = new ConsoleReporter();
            encounterOne.DoEncounter();
            Character EnconunterOneWinner = encounterOne.DecideWinner();
            EnconunterOneWinner.HealthItself();

            AttackEncounter encounterTwo = EncounterFactory.GetEncounter(EncounterType.Attack, characters[2], characters[3]) as AttackEncounter;
            encounterTwo.Reporter = new ConsoleReporter();
            encounterTwo.DoEncounter();
            Character EnconunterTwoWinner = encounterTwo.DecideWinner();
            EnconunterOneWinner.HealthItself();


            AttackEncounter encounterThree = EncounterFactory.GetEncounter(EncounterType.Attack, EnconunterOneWinner, EnconunterTwoWinner) as AttackEncounter;
            encounterThree.Reporter = new ConsoleReporter();
            encounterThree.DoEncounter();
            Character EnconunterThreeWinner = encounterThree.DecideWinner();
            EnconunterOneWinner.HealthItself();


            AttackEncounter Final = EncounterFactory.GetEncounter(EncounterType.Attack, EnconunterThreeWinner, characters[4]) as AttackEncounter;
            Final.Reporter = new ConsoleReporter();
            Final.DoEncounter();
            Character FinalWinner = Final.DecideWinner();
            EnconunterOneWinner.HealthItself();

            Console.WriteLine("The winner is: " + FinalWinner.Name);
        }
    }
}

