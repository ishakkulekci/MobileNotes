using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
//using Xamarin.Forms.Xaml;

namespace MobileNotes.Views
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            // launch the specified url in the system browser
            await Launcher.OpenAsync("https://aka.ms/xamarin-quickstart");
        }
    }
}