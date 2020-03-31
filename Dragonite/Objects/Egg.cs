using System;
namespace Dragonite.Objects
{
    public class Egg
    {

        const string eggStateKey = "eggState";
        const string eggXpKey = "eggXp";


        //Getting the xp of the egg which is the tempreature of the egg
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


        // warming egg 
        public void warmEgg()
        {
            Xp += 5;
        }

      
    }
}
