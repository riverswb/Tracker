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
    public partial class PoopPage : ContentPage
    {
        PoopDatabase poopDB = new PoopDatabase();
        public PoopPage()
        {
            InitializeComponent();

            var scaleEntry = new Entry();
            scaleEntry.SetBinding(Entry.TextProperty, "Bristol Scale Rating");

            var saveButton = new Button { Text = "Save" };
            saveButton.Clicked += async (sender, e) =>
            {
                var poop = (Poop)BindingContext;
                await poopDB.SavePoopAsync(poop);
            };
        }

        async void OnSaveClicked(object sender, EventArgs e)
        {
            var poop = (Poop)BindingContext;
            await poopDB.SavePoopAsync(poop);
            await Navigation.PopAsync();
        }
    }
}