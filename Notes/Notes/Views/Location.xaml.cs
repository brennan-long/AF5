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
           
            locationPicker.ItemsSource = new String[] { };
            

           airportInfo[] airports = new airportInfo[]   
            {
                new airportInfo("Robins Air Force Base", "Runway 1", ""),
                new airportInfo ("Hill Air Force Base", "Runway 2", ""),
                new airportInfo("Tinker Air Force Base", "Runway 3", ""),
                new airportInfo ("Shaw Air Force Base", "Runway 4", ""),
                new airportInfo ("Hartsfield-Jackson International Airport", "Runway 4", ""),
            };
            locationPicker.SelectedItem = airports[0];
            //locationPicker.ItemsSource = airports;
        }
        private void locationPicker_changed(object sender, EventArgs e)
        {
            Console.WriteLine("something");
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
        public airportInfo(string AIname, string AIrunway, string AirportID)
        {
            this.name = AIname;
            this.runwayinfo = AIrunway;
            string XRoot = "/html/body/table[5]/tr/td[1]";
            string url = "https://www.airnav.com/airport/" + AirportID;
            bool runway = true;
            int i = 1;
            while (runway)
            {
                string xpath = XRoot + "h4[" + i.ToString() + "]";
                if (WebScrape(xpath, url) != null)
                {

                }
            }
            string info = WebScrape(, url);
        }

        public airportInfo(string AIname)
        {
            this.name = AIname;
            this.runwayinfo = "";
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
            runwayinfo = AIrunway;
        }
        public HtmlNode WebScrape(string xpath, string url)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(url);
            return doc.DocumentNode.SelectNodes(xpath)[0];

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


