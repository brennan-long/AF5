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
                new airportInfo("Robins Air Force Base", "Runway 1")
            };
            picker3.SelectedItem = "";
            picker3.ItemsSource=airports;
        }

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
        public string Getrunwayinfo()
        {
            return runwayinfo;
        }
        public void Setrunwayinfo(string AIrunway)
        {
            runwayinfo= AIrunway;
        }

    }
         public static class lol
        {
            public static void run()
            {
                HtmlWeb web = new HtmlWeb();
                HtmlDocument doc = web.Load("https://www.airnav.com/airport/KHIF");
                var hilldim1 = doc.DocumentNode.SelectNodes("/html/body/table[5]/tr/td[1]/table[6]/tr[1]/td[2]")[0].InnerText;

            }
        }
    }


