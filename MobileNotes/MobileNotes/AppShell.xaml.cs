//using MobileNotes.ViewModels;
//using MobileNotes.Views;
//using System;
//using System.Collections.Generic;
using MobileNotes.Views;
using Xamarin.Forms;

namespace MobileNotes
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            //Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            //Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));

            Routing.RegisterRoute(nameof(NoteEntryPage), typeof(NoteEntryPage));

        }

    }
}
