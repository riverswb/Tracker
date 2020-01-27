using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracker.Data;
using Tracker.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tracker.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TodoItemPage : ContentPage
    {
        //TodoItemDatabase itemDB = new TodoItemDatabase();
        private TodoItemDatabase itemDB = TodoItemDatabase.DB;
        


        public TodoItemPage()
        {
            InitializeComponent();

            Title = "Todo Item";

            var nameEntry = new Entry();
            nameEntry.SetBinding(Entry.TextProperty, "Name");

            var notesEntry = new Entry();
            notesEntry.SetBinding(Entry.TextProperty, "Notes");

            var doneSwitch = new Switch();
            doneSwitch.SetBinding(Switch.IsToggledProperty, "Done");

            var saveButton = new Button { Text = "Save" };
            saveButton.Clicked += async (sender, e) =>
            {
                var todoItem = (TodoItem)BindingContext;
                await itemDB.SaveItemAsync(todoItem);

            };
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await itemDB.GetItemsAsync();
        }

        async void OnSaveClicked(object sender, EventArgs e)
        {
            var todoItem = (TodoItem)BindingContext;
            await itemDB.SaveItemAsync(todoItem);
            await Navigation.PopAsync();
        }

        async void OnDeleteClicked(object sender, EventArgs e)
        {
            var todoItem = (TodoItem)BindingContext;
            await itemDB.DeleteItemAsync(todoItem);
            await Navigation.PopAsync();
        }

        async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}