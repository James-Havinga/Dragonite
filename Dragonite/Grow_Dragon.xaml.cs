using System;
using System.Collections.Generic;
using System.ComponentModel;
using Dragonite.Objects;
using Xamarin.Forms;
using System.Timers;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Services;



namespace Dragonite
{
    public partial class Grow_Dragon : ContentPage
    {

        private Dragon dragon = new Dragon();
        private TimeKeeper timeKeeper = new TimeKeeper();

        private static Timer timer;


        public Grow_Dragon()
        {
            InitializeComponent();
            updateUI();
        }

        // Displaying the level and the amount of xp of the dragon
        public void updateUI()
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

            //Displaying the correct dragon image based on level

            Device.BeginInvokeOnMainThread(async () =>
            {
                dragonImage.Source = "dragon_" + Level.GetLevelFromXp(dragonXp).ToString();

                if (dragon.CurrentDragonState == DragonState.dead)
                {
                    DragonDied();
                }
            });

            
        }

        // Feeding dragon fucntionality

        void FeedDragon(System.Object sender, System.EventArgs e)
        {
            dragon.giveFood();

            updateUI();

            ResetTimer();
        }

        //What must happen when the dragon dies
        private async void DragonDied()
        {
            await DisplayAlert("Oh No", "Your Dragon has Died", "New Dragon");

            dragon.Xp = 0;
            dragon.CurrentDragonState = DragonState.healthy;
            updateUI();
            ResetTimer();
            await this.Navigation.PushModalAsync(new Hatching_Egg());


        }

        private void StartTimer()
        {
            timer = new Timer();

            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Elapsed += UpdateTimedData;
            timer.Start();
        }

        private void ResetTimer()
        {
            timeKeeper.StartTime = DateTime.Now;

            StartTimer();
        }

        //Changing the dragon state after certain times
        private void UpdateTimedData(object sender, ElapsedEventArgs e)
        {
            TimeSpan timeElapsed = e.SignalTime - timeKeeper.StartTime;

            DragonState newDragonState = dragon.CurrentDragonState;

            if (timeElapsed.TotalSeconds < 20)
            {
                newDragonState = DragonState.healthy;
            }
            else if (timeElapsed.TotalSeconds < 20)
            {
                newDragonState = DragonState.dead;
            }
            else if (timeElapsed.TotalSeconds >= 20)
            {
                newDragonState = DragonState.dead;
            }

            if (newDragonState != dragon.CurrentDragonState)
            {
                dragon.CurrentDragonState = newDragonState;
                updateUI();
            }
        }

        //Sleep functionality 
        async void Sleep(System.Object sender, System.EventArgs e)
        {
            background.Source = "night_background";
            xpLabel.TextColor = Color.White;
            levelLabel.TextColor = Color.White;
            dragon.giveFood();
            ResetTimer();
            await Task.Delay(5000);
            updateUI();
            background.Source = "dragon_background";
            xpLabel.TextColor = Color.Black;
            levelLabel.TextColor = Color.Black;

        }

        //Hunt Functionality 
        async void Hunt(System.Object sender, System.EventArgs e)
        {
            int dragonXp = dragon.Xp;

            dragon.giveFood();
            ResetTimer();
            background.Source = "hunt_background";
            dragonImage.Source = "none";
            await Task.Delay(5000);
            updateUI();
            background.Source = "dragon_background";
            dragonImage.Source = "dragon_" + Level.GetLevelFromXp(dragonXp).ToString();

        }

        //Training fucntionality by opening a popup when the button is clicked
        void Train(System.Object sender, System.EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new PopupView());
        }
    }
}
