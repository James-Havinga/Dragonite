using System;
namespace Dragonite.Objects
{
    public enum DragonState
    {
        baby,
        child,
        teen,
        youngadult,
        adult
    }
    class DragonStates
    {
        public static string GetDragonString(DragonState dragonState)
        {
            switch (dragonState)
            {
                case DragonState.baby:
                    return "baby";

                case DragonState.child:
                    return "child";

                case DragonState.teen:
                    return "teen";

                case DragonState.youngadult:
                    return "youngadult";

                case DragonState.adult:
                    return "adult";

                default:
                    return "baby";
            }
        }

        public static DragonState GetDragonState(string dragonString)
        {
            switch (dragonString)
            {
                case "baby":
                    return DragonState.baby;

                case "child":
                    return DragonState.child;

                case "teen":
                    return DragonState.teen;

                case "youngadult":
                    return DragonState.youngadult;

                case "adult":
                    return DragonState.adult;

                default:
                    return DragonState.baby;
            }
        }
    }
}


