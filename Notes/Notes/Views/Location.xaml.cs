using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HtmlAgilityPack;

namespace Notes.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Location : ContentPage
    {
        public Location()
        {
            InitializeComponent();
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb;
            HtmlAgilityPack.HtmlDocument doc = web.Load("https://www.weatherbug.com/weather-forecast/now/robins-air-force-base-ga-31098");
            foreach (var item in doc.DocumentNode.SelectNodes("/html/body/main/section[1]/div[2]/div/div[2]/div/div[2]/div/div/div/div/div/div/div/div/ul/li[1]/div/div/div/current-conditions-widget/div/div/div[1]"))
            {

            }
        }
    }
}