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
                new plane("ldjfa", "adfawef"),
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
        string weight;
        string slots;
        public plane(string w, string s)
        {
            weight = w;
            slots = s;
        }

        public string calculate(int num)
        {
            return weight + num;
        }

        public override string ToString()
        {
            return weight;
        }
    }
       
}

