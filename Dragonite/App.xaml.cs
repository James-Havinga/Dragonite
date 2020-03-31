using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Dragonite.Helpers;

namespace Dragonite
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Checking to see if its a frist time user 
            if (IsFristTime == "yes")
            {
                IsFristTime = "no";
                MainPage = new MainPage();

            }
            else
            {
                MainPage = new Dragonite.Hatching_Egg();
            }


        }

        public string IsFristTime
        {
            get { return Settings.GeneralSettings; }
            set
            {
                if (Settings.GeneralSettings == value)
                    return;

                Settings.GeneralSettings = value;
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
