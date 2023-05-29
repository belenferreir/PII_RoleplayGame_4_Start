using System;
using System.Collections.Generic;
using RoleplayGame.Encounters;
using RoleplayGame.Characters;
using RoleplayGame.Items;
using RoleplayGame.Scenarios;

/*namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            IScenario scenario = new ConsoleScenario();
            scenario.Setup();
            scenario.Run();
        }
    }
}*/


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
           IScenario escenario = new ScenaryTest();
           escenario.Setup();
           escenario.Run();
        }
    }
}

