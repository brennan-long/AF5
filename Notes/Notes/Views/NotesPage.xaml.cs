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

                new plane("C-5","400,000","685,000","5", "8300", "4900"),
                new plane("C-17", "282,400", "453,300", "4", "8200", "3500"),
                new plane("C-130", "75,840", "119,840", "3", "3586", "2500"),
                new plane("F-15", "45,000", "68,000", "2", "1000", "1650"),
                new plane("Boeing 747", "404,600", "653,200", "5", "10450", "6920")
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

