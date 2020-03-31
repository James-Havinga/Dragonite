using System;
namespace Dragonite.Objects
{
    public class Dragon
    {
        const string dragonStateKey = "dragonState";
        const string dragonXpKey = "dragonXp";


        //Getting the current dragon state if there  is one or jsut giving one if there isnt
        public DragonState CurrentDragonState
        {
            get
            {
                if (App.Current.Properties.ContainsKey(dragonStateKey))
                {
                    return DragonStates.GetDragonState((string)App.Current.Properties[dragonStateKey]);
                }
                else
                {
                    return DragonState.healthy;
                }
            }
            set
            {
                App.Current.Properties[dragonStateKey] = DragonStates.GetDragonString(value);
            }
        }


        //getting the xp of the dragon or giving it a value of 0 if its first time user
        public int Xp
        {
            get
            {
                if (App.Current.Properties.ContainsKey(dragonXpKey))
                {
                    Console.WriteLine((int)App.Current.Properties[dragonXpKey]);
                    return (int)App.Current.Properties[dragonXpKey];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                App.Current.Properties[dragonXpKey] = value;
            }
        }

        public Dragon()
        {

        }

        //give food function to give dragon xp
        public void giveFood()
        {
            Xp += 200;
        }

        
    }
}
