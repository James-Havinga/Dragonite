using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Dragonite
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        //Start button sending them to the egg hatching page 
        async void Start_Hatching(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new Hatching_Egg());
        }
    }
}
