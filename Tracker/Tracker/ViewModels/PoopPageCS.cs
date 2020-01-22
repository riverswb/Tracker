using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Tracker.Models;
using System.Threading.Tasks;

namespace Tracker.ViewModels
{
    public class PoopPageCS : ContentPage
    {
        public PoopPageCS()
        {
            Title = "New Poop";
            var scaleBinding = new Entry();
            scaleBinding.SetBinding(Entry.TextProperty, "Bristol Stool Scale");

            var saveButton = new Button { Text = "Save" };
            saveButton.Clicked += async (sender, e) =>
            {
                var poop = (Poop)BindingContext;
                await SavePoopAsync(poop);
                await Navigation.PopAsync();
            };
        }

        private Task SavePoopAsync(Poop poop)
        {
            throw new NotImplementedException();
        }
    }
}
