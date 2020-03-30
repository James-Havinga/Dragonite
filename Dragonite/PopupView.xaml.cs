using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Rg.Plugins.Popup.Services;
using Dragonite.Objects;
using Dragonite;

namespace Dragonite
{
    public partial class PopupView
    {

        private Dragon dragon = new Dragon();
        
        public PopupView()
        {
            InitializeComponent();
        }

        void Training(System.Object sender, System.EventArgs e)
        {
            var update = new Dragonite.Grow_Dragon();
            dragon.giveFood();
            

            PopupNavigation.Instance.PopAsync(true);

            update.updateUI();
        }
    }
}
