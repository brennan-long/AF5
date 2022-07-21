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


           airportInfo[] airports =
            {
                new airportInfo("Robins Air Force Base", "Runway 1"),
                new airportInfo ("Hill Air Force Base", "Runway 2"),
                new airportInfo("Tinker Air Force Base", "Runway 3"),
                new airportInfo ("Shaw Air Force Base", "Runway 4"),
                new airportInfo ("Hartsfield-Jackson International Airport", "Runway 4"),
            };
            locationPicker.SelectedItem = airports[0];
            locationPicker.ItemsSource = airports;
        }
        private void locationPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (picker3.SelectedItem != null)
            //{
            //    InfoAP.currentAirport = (picker3.SelectedItem as airportInfo);
            //}

        }
    }

    static class InfoAP
    {
        static public airportInfo currentAirport = null;
    }

    public class airportInfo
    {
        public string name;
        public string runwayinfo;
        public airportInfo(string AIname, string AIrunway)
        {
            this.name = AIname;
            this.runwayinfo = AIrunway;
        }

        public airportInfo(string AIname)
        {
            this.name = AIname;
        }

        public override string ToString()
        {
            return name;
        }


        public string Getrunwayinfo()
        {
            return runwayinfo;
        }
        public void Setrunwayinfo(string AIrunway)
        {
            runwayinfo= AIrunway;
        }

    }

        /* public static class lol

        {
            public static void run()
            {
                HtmlWeb web = new HtmlWeb();
                HtmlDocument doc = web.Load("https://www.airnav.com/airport/KHIF");
                var hilldim1 = doc.DocumentNode.SelectNodes("/html/body/table[5]/tr/td[1]/table[6]/tr[1]/td[2]")[0].InnerText;

            }
        }*/
    }


