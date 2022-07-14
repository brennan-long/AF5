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
            planeInfo[] planes =
            {
                new planeInfo("C-5",400000,685000,5, 8300, 4900),
                new planeInfo("C-17", 282400, 453300, 4, 8200, 3500),
                new planeInfo("C-130", 75840, 119840, 3, 3586, 2500),
                new planeInfo("F-15", 45000, 68000, 2, 1000, 1650),
                new planeInfo("Boeing 747", 404600, 653200, 5, 10450, 6920)

            };
            picker1.SelectedItem = "";
            picker1.ItemsSource = planes;

        }

        void OnButtonClicked_T(object sender, EventArgs e)
        {
          
        }

        void OnButtonClicked_L(object sender, EventArgs e)
        {         
                     
        }

        private void picker1_SelectedIndexChanged(object sender, EventArgs e)
        {
            planeLabel.Text = (picker1.SelectedItem as planeInfo).name.ToString();
        }
    }

    public class planeInfo
        {
            public string name;
            int baseweight;
            int maxweight;
            int slots;
            int takeoffdistance;
            int landingdistance;

            public planeInfo(string n, int bw, int mw, int S, int td, int ld)
            {
                this.name = n;
                this.baseweight = bw;
                this.maxweight = mw;
                this.slots = S;
                this.takeoffdistance = td;
                this.landingdistance = ld;           
            }
            public planeInfo(string n)
            {
                this.name=n;
            }
            public int Getbw()
            {
                return baseweight;
            }
            public void Setbw(int bw)
            {
                baseweight = bw;
            }
            public int Getmw()
            {
                return maxweight;
            }
            public void Setmw(int mw)
            {
                maxweight = mw;
            }
            public int GetS()
            {
                return slots;
            }
            public void SetS(int S)
            {
                slots = S;
            }
            public int Gettd()
            {
                return takeoffdistance;
            }
            public void Settd(int td)
            {
                takeoffdistance = td;
            }
            public int Getld()
            {
                return landingdistance;
            }
            public void Setld(int ld)
            {
                landingdistance = ld;
            }








        public int Name()
        {
            return maxweight;
        }
        public int calculate(int num)
        {
            return baseweight + num;
        }

        public override  string ToString()
        {
            return name;

        }
        public int Slots()
        {
            return slots;
        }
        public int Takeoff()
        {
            return takeoffdistance;
        }
        public int Landing()
        {
            return landingdistance;
        }

    }
       
}

