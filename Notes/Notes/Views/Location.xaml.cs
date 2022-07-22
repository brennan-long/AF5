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
                new airportInfo("Robins Air Force Base"),
                new airportInfo ("Hill Air Force Base"),
                new airportInfo("Tinker Air Force Base"),
                new airportInfo ("Shaw Air Force Base"),
                new airportInfo ("Hartsfield-Jackson International Airport"),
            };
            locationPicker.SelectedItem = "";
            locationPicker.ItemsSource = airports;            
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
        public airportInfo(string AIname)
        {
            this.name = AIname;
        }
        public override string ToString()
        {
            return name;
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


