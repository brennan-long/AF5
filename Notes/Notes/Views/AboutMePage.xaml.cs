using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Notes.Views
{
    public partial class AboutMePage : ContentPage
    {
        public AboutMePage()
        {
            InitializeComponent();
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
             await Launcher.OpenAsync("https://en.wikipedia.org/wiki/Trollface");
        }
        async void OnButtonClicked_1(object sender, EventArgs e)
        {
            await Launcher.OpenAsync("https://www.etsy.com/shop/BrennansSpace?ref=seller-platform-mcnav");
        }
        async void OnButtonClicked_2(object sender, EventArgs e)
        {
            await Launcher.OpenAsync("https://www.instagram.com/brenni_s_art/");
        }
        async void OnButtonClicked_3(object sender, EventArgs e)
        {
            await Launcher.OpenAsync("https://www.mtu.edu/biomedical/department/what-is/");
        }
        async void OnButtonClicked_4(object sender, EventArgs e)
        {
            await Launcher.OpenAsync("https://www.youtube.com/watch?v=3qpMnlKioPw");
        }
    }
}