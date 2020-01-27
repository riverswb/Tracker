using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracker.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Tracker.Models;

namespace Tracker.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PoopListPage : ContentPage
    {
        private PoopDatabase poopDB = PoopDatabase.DB;
        public PoopListPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await poopDB.GetPoopsAsync();
        }

        async void OnPoopAdded(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PoopPage
            {
                BindingContext = new Poop()
            });
        }

        async void OnPoopSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem != null)
            {
                await Navigation.PushAsync(new PoopPage
                {
                    BindingContext = e.SelectedItem as Poop
                });
            }
        }

    }
}