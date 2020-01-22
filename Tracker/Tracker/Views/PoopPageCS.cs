using Xamarin.Forms;
using Tracker.Models;
using Tracker.Data;

namespace Tracker.Views
{
    class PoopPageCS : ContentPage
    {
        private PoopDatabase poopDB = PoopDatabase.DB;

        public PoopPageCS()
        {
            Title = "Poop";

            var scaleEntry = new Entry();
            scaleEntry.SetBinding(Entry.TextProperty, "Bristol Scale Rating");

            var saveButton = new Button { Text = "Save" };
            saveButton.Clicked += async (sender, e) =>
            {
                var todoItem = (Poop)BindingContext;
                await poopDB.SavePoopAsync(todoItem);
                await Navigation.PopAsync();
            };

        }
    }
}
