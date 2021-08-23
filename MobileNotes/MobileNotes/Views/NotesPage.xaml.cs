using MobileNotes.Models;
using System;
using System.Collections.Generic;
//using System.Collections.Generic;
using System.IO;
using System.Linq;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

using Xamarin.Forms;
//using Xamarin.Forms.Xaml;

namespace MobileNotes.Views
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotesPage : ContentPage
    {
        //string _fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "notes.txt");

        public NotesPage()
        {
            InitializeComponent();

            //// read the file
            //if (File.Exists(_fileName))
            //{
            //    editor.Text = File.ReadAllText(_fileName);
            //}
        }

        //void OnSaveButtonClicked(object sender, EventArgs e)
        //{
        //    // save the file
        //    File.WriteAllText(_fileName, editor.Text);
        //}

        //void OnDeleteButtonClicked(object sender, EventArgs e)
        //{
        //    // delete the file
        //    if (File.Exists(_fileName))
        //    {
        //        File.Delete(_fileName);
        //    }

        //    editor.Text = string.Empty;
        //}

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var notes = new List<Note>();

            // Create a Note object from each file.
            var files = Directory.EnumerateFiles(App.FolderPath, "*.notes.txt");

            foreach (var filename in files)
            {
                notes.Add(new Note {
                    Date = File.GetCreationTime(filename),
                    Filename = filename,
                    Text = File.ReadAllText(filename)
                });
            }

            // Set the data source for the CollectionView to a
            // sorted collection of notes.
            collectionView.ItemsSource = notes.OrderBy(d => d.Date).ToList();

        }

        async void OnAddClicked(object sender, EventArgs e)
        {
            // Navigate to the NoteEntryPage, without passing any data.
            await Shell.Current.GoToAsync(nameof(NoteEntryPage));
        }

        async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection != null)
            {
                // Navigate to the NoteEntryPage, passing the filename as a query parameter.
                Note note = (Note)e.CurrentSelection.FirstOrDefault();

                await Shell.Current.GoToAsync($"{nameof(NoteEntryPage)}?{nameof(NoteEntryPage.ItemId)}={note.Filename}");
            }
        }

    }
}