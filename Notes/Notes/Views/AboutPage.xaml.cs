using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Notes.Views
{
    public partial class AboutPage : ContentPage
    {
        slotsInfo[] slots;
        Picker[] pickers;
        public AboutPage()
        {
            InitializeComponent();

            slots = new slotsInfo[]
            {
                new slotsInfo("Select", 0),
                new slotsInfo("Humvee", 7700),
                new slotsInfo("M1 Tank", 120000),
                new slotsInfo("UH-60 Blackhawk", 13650),
                new slotsInfo("Stryker ICV", 32940),
                new slotsInfo("CV90", 54000)
            };

            pickers = new Picker[]
            {
                picker1, picker2, picker3, picker4, picker5
            };

            foreach (var picker in pickers)
            {
                picker.ItemsSource = slots;
                picker.IsEnabled = false;
            }

            for (int i = 0; i < Info.currentPlane.slots; i++)
            {
                pickers[i].IsEnabled = true;
            }

        }
        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Info.currentPlane != null)
            {
                int weight = 0;

                foreach (var picker in pickers)
                {
                    if (picker.SelectedItem != null)
                    {
                        weight += (picker.SelectedItem as slotsInfo).weight;
                    } else
                    {
                        picker.SelectedItem = new slotsInfo("Select", 0);
                    }
                }

                int frontweight = 0;
                int backweight = 0;

                switch (Info.currentPlane.slots)
                {
                    default:
                        break;
                    case 2:
                        frontweight = (picker1.SelectedItem as slotsInfo).weight;
                        backweight = (picker2.SelectedItem as slotsInfo).weight;
                        break;
                    case 3:
                        frontweight = (picker1.SelectedItem as slotsInfo).weight;
                        backweight = (picker3.SelectedItem as slotsInfo).weight;
                        break;
                    case 4:
                        frontweight = ((picker1.SelectedItem as slotsInfo).weight * 2) + (picker2.SelectedItem as slotsInfo).weight;
                        backweight = ((picker4.SelectedItem as slotsInfo).weight * 2) + (picker3.SelectedItem as slotsInfo).weight;
                        break;
                    case 5:
                        frontweight = ((picker1.SelectedItem as slotsInfo).weight * 2) + (picker2.SelectedItem as slotsInfo).weight;
                        backweight = ((picker5.SelectedItem as slotsInfo).weight * 2) + (picker4.SelectedItem as slotsInfo).weight;
                        break;

                }

                float balance = (frontweight - backweight) / Info.currentPlane.baseweight;
                int totalWeight = (weight + Info.currentPlane.baseweight);

                balanceResults.Text = "I guess your plane is balanced lol";
                aircraftWeight.Text = totalWeight.ToString();
                balanceResults.TextColor = Color.Green;
                aircraftWeight.TextColor = Color.Green;
                takeoffRecomendations.Text = "Go ahead and take off private";
                takeoffRecomendations.TextColor = Color.Green;

                if (balance > 0.1 || balance < -0.1)
                {
                    balanceResults.Text = "This is not balanced at all, do you want to die?";
                    balanceResults.TextColor = Color.Red;
                    takeoffRecomendations.Text = "you will die if you try to take off";
                }
                if (totalWeight > Info.currentPlane.maxweight)
                {
                    aircraftWeight.TextColor = Color.Red;
                    takeoffRecomendations.Text = "we can not take off with all this junk";
                    takeoffRecomendations.TextColor = Color.Red;
                }

            }
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            // Launch the specified URL in the system browser.
            await Launcher.OpenAsync("https://en.wikipedia.org/wiki/Trollface");
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            foreach (var picker in pickers)
            {
                picker.ItemsSource = slots;
                picker.IsEnabled = false;
            }

            for (int i = 0; i < Info.currentPlane.slots; i++)
            {
                pickers[i].IsEnabled = true;
            }
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
