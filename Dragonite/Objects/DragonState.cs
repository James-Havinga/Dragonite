using System;
namespace Dragonite.Objects
{
    public enum DragonState
    {
        healthy,
        dead
    }
    public class DragonStates
    {

        // Difffernt possible states the dragon can have
        public static string GetDragonString(DragonState dragonState)
        {
            switch (dragonState)
            {
                case DragonState.healthy:
                    return "healthy";

                case DragonState.dead:
                    return "dead";

                default:
                    return "healthy";
            }
        }

        public static DragonState GetDragonState(string dragonString)
        {
            switch (dragonString)
            {
                case "healthy":
                    return DragonState.healthy;

                case "dead":
                    return DragonState.dead;

                default:
                    return DragonState.healthy;
            }
        }
    }
}


