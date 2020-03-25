using System;
namespace Dragonite.Objects
{
    public enum EggState
    {
        unhatched,
        hatched
    }

    class EggStates
    {
        public static string GetEggString(EggState eggState)
        {
            switch (eggState)
            {
                case EggState.unhatched:
                    return "unhatched";

                case EggState.hatched:
                    return "hatched";

                default:
                    return "unhatched";
            }
        }

        public static EggState GetEggState(string eggString)
        {
            switch (eggString)
            {
                case "unhatched":
                    return EggState.unhatched;

                case "dead":
                    return EggState.hatched;

                default:
                    return EggState.unhatched;
            }
        }
    }
}
