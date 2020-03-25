using System;
namespace Dragonite.Objects
{
    public class Egg
    {

        const string eggStateKey = "eggState";
        const string eggXpKey = "eggXp";

        public int Xp
        {
            get
            {
                if (App.Current.Properties.ContainsKey(eggXpKey))
                {
                    Console.WriteLine((int)App.Current.Properties[eggXpKey]);
                    return (int)App.Current.Properties[eggXpKey];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                App.Current.Properties[eggXpKey] = value;
            }
        }

        public void warmEgg()
        {
            Xp += 5;
        }

        public void coolEgg()
        {
            Xp -= 1;
        }
    }
}
