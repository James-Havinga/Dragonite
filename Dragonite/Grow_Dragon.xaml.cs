using System;
using System.Collections.Generic;
using System.ComponentModel;
using Dragonite.Objects;
using Xamarin.Forms;
using System.Timers;


namespace Dragonite
{
    public partial class Grow_Dragon : ContentPage
    {

        private Dragon dragon = new Dragon();


        public Grow_Dragon()
        {
            InitializeComponent();
            updateUI();
        }

        void updateUI()
        {
            int dragonXp = dragon.Xp;

            if (dragonXp < 1)
            {
                levelLabel.Text = "New Dragon";
                xpLabel.Text = "Tap the food button to feed dragon";
            }
            else
            {
                levelLabel.Text = "Level " + Level.GetLevelFromXp(dragonXp).ToString();
                xpLabel.Text = dragonXp.ToString();
            }


            dragonImage.Source = "dragon_" + dragon.CurrentDragonState + "_" + Level.GetLevelFromXp(dragonXp).ToString();
        }



        void FeedDragon(System.Object sender, System.EventArgs e)
        {
            dragon.giveFood();

            updateUI();
        }
    }
}
