using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using System.Timers;
using Dragonite.Objects;
using System.Threading.Tasks;

namespace Dragonite
{
    [DesignTimeVisible(false)]

    

    public partial class Hatching_Egg : ContentPage
    {

        private Egg egg = new Egg();

        private TimeKeeper timeKeeper = new TimeKeeper();

        private static Timer timer;

        public Hatching_Egg()
        {
            InitializeComponent();


            UpdateUI();



        }





        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await Task.Delay(20000);
            await this.Navigation.PushModalAsync(new Grow_Dragon());
        }

        void UpdateUI()
        {

            int eggXp = egg.Xp;

            if (eggXp < 15)
            {
                tempLabel.Text = "YOUR EGG IS TOO COLD !";
            }
            else if (eggXp > 35)
            {
                tempLabel.Text = "YOUR EGG IS TOO HOT !";
            }
            else
            {
                tempLabel.Text = eggXp.ToString() + " °C";
            }

        } 

        void WarmEgg(System.Object sender, System.EventArgs e)
        {
            egg.warmEgg();
            UpdateUI();
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

            if (timeElapsed.TotalSeconds > 2)
            {

                Console.WriteLine("2 seconds has passed");
                egg.coolEgg();

                UpdateUI();

                ResetTimer();

             
            }
           
        }

    }
      
    

    
}

