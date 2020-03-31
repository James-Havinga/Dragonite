using System;
namespace Dragonite.Objects
{
    public class Level
    {

        //Calculating the level of the dragon based on how much xp it has
        public static int GetLevelFromXp(int xp)
        {
            if (xp < 1000)
            {
                return 0;
            }
            else if(xp == 1000)
            {
                return 0;
            }
            else if (xp < 2000)
            {
                return 1;
            }
            else if (xp == 2000)
            {
                return 1;
            }
            else if(xp < 3000)
            {
                return 2;
            } 
            else if(xp == 3000)
            {
                return 2;
            }
            else if(xp < 4000)
            {
                return 3;
            }
            else if(xp == 4000)
            {
                return 3;
            }
            else if(xp < 5000)
            {
                return 4;
            }
            else if(xp >= 5000)
            {
                return 4;
            }
            else
            {
                return 0;
            }
        }

    }
}
