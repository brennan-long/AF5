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

            
           
        }

        void OnButtonClicked_T(object sender, EventArgs e)
        {
          
        }

        void OnButtonClicked_L(object sender, EventArgs e)
        {         
                     
        }
    }
}