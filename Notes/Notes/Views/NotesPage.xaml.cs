using System;
using System.IO;
using Xamarin.Forms;

namespace Notes.Views
{
    public partial class NotesPage : ContentPage
    {
        string _fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "notes.txt");

        public NotesPage()
        {
            InitializeComponent();
            plane[] planes =
            {

                new plane("C5","400,000","hm12","bruh", "wow", "wind"),
                new plane("F-15", "1500", "2 Slots", "other things", "yea", "this sucks")
            };

            picker1.ItemsSource = planes;

        }

        void OnButtonClicked_T(object sender, EventArgs e)
        {
          
        }

        void OnButtonClicked_L(object sender, EventArgs e)
        {         
                     
        }
    }

    public class plane
    {

        string name;
        string baseweight;
        string maxweight;
        string slots;
        string takeoffdistance;
        string landingdistance;
        
        public plane(string n, string bw, string mw, string s, string td, string ld)
        {
            name = n;
            baseweight = bw;
            maxweight = mw;
            slots = s;
            takeoffdistance = td;
            landingdistance = ld;
        }

        public string Name()
        {
            return maxweight;
        }
        public string calculate(int num)
        {
            return baseweight + num;
        }

        public override  string ToString()
        {
            return name;

        }
        public string Slots()
        {
            return slots;
        }
        public string Takeoff()
        {
            return takeoffdistance;
        }
        public string Landing()
        {
            return landingdistance;
        }

    }
       
}

