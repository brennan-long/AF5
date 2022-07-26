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
        public HtmlDocument airportDoc;
        public HtmlDocument weatherDoc;
        public string airports;
        public string weather;
        public Location()
        {
            InitializeComponent();

            airports = "https://www.airnav.com/airports/";
            weather = "https://weather.com/weather/today/l/";

            HtmlWeb web = new HtmlWeb();

            Dictionary<string, string[]> dic1 = new Dictionary<string, string[]>();
            dic1.Add("Robins Air Force Base", new string[] { "KWRB", "bf68a280de7675457e6bbc0bf18f95d4da42875e86ac5dd7f19a243ec918f978" });
            dic1.Add("Hill Air Force Base", new string[] { "KHIF", "b8a1ed216efdd87df356b711c371026bc333c20afe1cfec33da8a3e33e9785f8" });
            dic1.Add("Tinker Air Force Base", new string[] { "KTIK", "2f1fc1a42db8ce5905c09e81e950aa8490a03ccf3fc0531201aa36121203afbf" });
            dic1.Add("Shaw Air Force Base", new string[] { "KSSC", "a8ede61251306f21eacd611484a4dc6b7e096460250b4ddacb63069cd5990850" });
            dic1.Add("Atlanta", new string[] { "KATL", "5ac25efae2da09ef41a88d34d013308e7e65963c09e202cb63ee11437c619d71" });


            String[] baselist =
            {
                "Robins Air Force Base",
                "Hill Air Force Base",
                "Tinker Air Force Base",
                "Shaw Air Force Base",
                "Atlanta",
            };
            locationPicker.ItemsSource = baselist;

            locationPicker.SelectedIndexChanged += (sender, args) =>
            {
                runwayPicker.Items.Clear();

                airportDoc = web.Load(airports + dic1[locationPicker.SelectedItem.ToString()][0]);
                weatherDoc = web.Load(weather + dic1[locationPicker.SelectedItem.ToString()][1]);

                var loc = weatherDoc.DocumentNode.SelectNodes("/html/body/div[1]/main/div[2]/main/div[1]/div/section/div/div[1]/h1").First().InnerText;
                locDisplay.Text = loc;
                var temp = weatherDoc.DocumentNode.SelectNodes("/html/body/div[1]/main/div[2]/main/div[1]/div/section/div/div[2]/div[1]/div[1]/span").First().InnerText;
                tempDisplay.Text = temp;
                var wind = weatherDoc.DocumentNode.SelectNodes("//section/div[2]/div[2]/div[2]/span").First().InnerText;
                wind = wind.Remove(0, 14);
                windDisplay.Text = wind;

                foreach (var item in airportDoc.DocumentNode.SelectNodes(runway))
                {
                    var run = item.InnerText;
                    string[] name = run.Split('/');
                    runwayPicker.Items.Add(name[0]);
                    runwayPicker.Items.Add("Runway " + name[1]);
                }
            };
        }
    }
}

           /* locationPicker.ItemsSource = new String[] { };
            

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
        }
    }*/


