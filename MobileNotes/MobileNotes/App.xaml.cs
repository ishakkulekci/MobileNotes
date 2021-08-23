//using MobileNotes.Services;
//using MobileNotes.Views;
//using System;
using System;
using System.IO;
using Xamarin.Forms;
//using Xamarin.Forms.Xaml;

namespace MobileNotes
{
    public partial class App : Application
    {

        //docs: https://docs.microsoft.com/en-us/xamarin/get-started/quickstarts/navigation?pivots=windows

        public static string FolderPath { get; set; }

        public App()
        {
            InitializeComponent();

            //DependencyService.Register<MockDataStore>();

            FolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
