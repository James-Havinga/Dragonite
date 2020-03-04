using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Dragonite
{
    public partial class Hatching_Egg : ContentPage
    {
        public Hatching_Egg()
        {
            InitializeComponent();
        }

        async void Grow_Dragon(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new Grow_Dragon());
        }
    }
}
