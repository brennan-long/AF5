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
            string[] planeName = new string[] { "C-5", "C-17", "C-130", "F-15", "Boeing 747" };
            int[] planebw = new int[] {400000,282000,75840,45000,404600 };
            int[] planemw = new int[] {685000, 453300, 119840, 68000, 404600 };
            int[] planeS = new int[] {5,4,3,2,5 };
            int[] planetd = new int [] { 8300, 8200,3586 ,1000 ,10450  };
            int[] planeld = new int[] { 4900,3500 ,2500 ,1650 ,6920  };

            planeInfo[] list = new planeInfo[planeName.Length];
            for (int i = 0; i < planeName.Length; i++)
            {
                list[i] = new planeInfo(planeName[i]);
                picker1.ItemsSource = planeName[];
            }
           /* plane[] planes =
            {


                new plane("C-5","400,000","685,000","5", "8300", "4900"),
                new plane("C-17", "282,400", "453,300", "4", "8200", "3500"),
                new plane("C-130", "75,840", "119,840", "3", "3586", "2500"),
                new plane("F-15", "45,000", "68,000", "2", "1000", "1650"),
                new plane("Boeing 747", "404,600", "653,200", "5", "10450", "6920")

            };

            picker1.ItemsSource = planes;*/

        }

        void OnButtonClicked_T(object sender, EventArgs e)
        {
          
        }

        void OnButtonClicked_L(object sender, EventArgs e)
        {         
                     
        }
    }

    public class planeInfo
    {

        string name;
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

