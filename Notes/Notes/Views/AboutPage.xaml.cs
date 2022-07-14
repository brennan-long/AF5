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
            aircraftWeight.Text = Info.currentPlane.baseweight.ToString();
            balanceResults.Text = "this really sucks";
            takeoffRecomendations.Text = "like really really sucks";

        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            // Launch the specified URL in the system browser.
            await Launcher.OpenAsync("https://en.wikipedia.org/wiki/Trollface");
        }
        slotsInfo[] slots =
   {
        new slotsInfo("Humvee", 7700),
        new slotsInfo("M1 Tank", 120000),
        new slotsInfo("UH-60 Blackhawk", 13650),
        new slotsInfo("Stryker ICV", 32940),
        new slotsInfo("CV90", 54000)
    };
        private string n;

        public class slotsInfo
        {
            public string name;
            public int weight;

            public slotsInfo(string n, int w)
            {
                this.name = n;
                this.weight = w;
            }
        }
        public string Getn()
        {
            return n;
        }
    }

}





