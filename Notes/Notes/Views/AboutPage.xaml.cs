using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Notes.Views
{
    public partial class AboutPage : ContentPage
    {
        slotsInfo[] slots;
        public AboutPage()
        {
            InitializeComponent();

            aircraftWeight.Text = "this sucks";

            if (Info.currentPlane != null)
            {
                aircraftWeight.Text = Info.currentPlane.baseweight.ToString();
            }

            balanceResults.Text = "this really sucks";
            takeoffRecomendations.Text = "like really really sucks";

            slots = new slotsInfo[]
            {
                new slotsInfo("Select", 0),
                new slotsInfo("Humvee", 7700),
                new slotsInfo("M1 Tank", 120000),
                new slotsInfo("UH-60 Blackhawk", 13650),
                new slotsInfo("Stryker ICV", 32940),
                new slotsInfo("CV90", 54000)
            };

            picker1.ItemsSource = slots;
            picker2.ItemsSource = slots;
            picker3.ItemsSource = slots;
            picker4.ItemsSource = slots;
            picker5.ItemsSource = slots;
        }
        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            int weight = (picker1.SelectedItem as slotsInfo).weight;
            aircraftWeight.Text = weight.ToString();
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            // Launch the specified URL in the system browser.
            await Launcher.OpenAsync("https://en.wikipedia.org/wiki/Trollface");
        }
    }
    public class slotsInfo
    {
        public string name;
        public int weight;

        public slotsInfo(string n, int w)
        {
            this.name = n;
            this.weight = w;
        }
        public override string ToString()
        {
            return name;
        }
    }
}





