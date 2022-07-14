using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Notes.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            aircraftWeight.Text = "this sucks";
            balanceResults.Text = "this really sucks";
            takeoffRecomendations.Text = "like really really sucks";

        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            // Launch the specified URL in the system browser.
            await Launcher.OpenAsync("https://en.wikipedia.org/wiki/Trollface");
        }      
    }
}

