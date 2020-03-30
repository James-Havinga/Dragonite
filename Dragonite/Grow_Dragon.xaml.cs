﻿using System;
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


            Device.BeginInvokeOnMainThread(async () =>
            {
                dragonImage.Source = "dragon_" + Level.GetLevelFromXp(dragonXp).ToString();

                if (dragon.CurrentDragonState == DragonState.dead)
                {
                    DragonDied();
                }
            });

            
        }



        void FeedDragon(System.Object sender, System.EventArgs e)
        {
            dragon.giveFood();

            updateUI();

            ResetTimer();
        }

        private async void DragonDied()
        {
            await DisplayAlert("Oh No", "Your Dragon has Died", "New Dragon");

            dragon.Xp = 0;
            dragon.CurrentDragonState = DragonState.healthy;
            updateUI();
            ResetTimer();
            
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

        async void Sleep(System.Object sender, System.EventArgs e)
        {
            background.Source = "night_background";
            xpLabel.TextColor = Color.White;
            levelLabel.TextColor = Color.White;
            dragon.giveFood();
            await Task.Delay(10000);
            updateUI();
            background.Source = "dragon_background";
            xpLabel.TextColor = Color.Black;
            levelLabel.TextColor = Color.Black;

        }

        async void Hunt(System.Object sender, System.EventArgs e)
        {
            int dragonXp = dragon.Xp;

            dragon.giveFood();

            background.Source = "hunt_background";
            dragonImage.Source = "none";
            await Task.Delay(10000);
            updateUI();
            background.Source = "dragon_background";
            dragonImage.Source = "dragon_" + Level.GetLevelFromXp(dragonXp).ToString();

        }

        void Train(System.Object sender, System.EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new PopupView());
        }
    }
}
