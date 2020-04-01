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

        //function to go to next page after a certain time ie: the egg hatching
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await Task.Delay(10000);
            await this.Navigation.PushModalAsync(new Grow_Dragon());
        }

        // displaying the tempreature of the egg
        public void UpdateUI()
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


        // button to warm the egg
        void WarmEgg(System.Object sender, System.EventArgs e)
        {
            egg.warmEgg();
            UpdateUI();
          
        }

        

    }
      
    

    
}

