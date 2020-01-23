using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Tracker.Data;
using Tracker.Models;

namespace Tracker.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuantityListPage : ContentPage
    {

        
            
 
        private BaseDatabase baseDB = BaseDatabase.DB;
        public QuantityListPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = Tables;
        }
        private string[] Tables = new string[2]
        {
            "TodoItem",
            "Poop"
        };

    async void OnQuantitySelected(object sender, SelectedItemChangedEventArgs e)
        {

            if (e.SelectedItem != null)
            {
                string quantity = e.SelectedItem.ToString();
                //var quantity = Tables[e.SelectedItem.name];
                int id = Array.IndexOf(Tables, quantity);

                if(id == 0)
                {
                    await Navigation.PushAsync(new TodoItemPage
                    {
                        BindingContext = e.SelectedItem as TodoItem
                    });

                }
                if (id == 1)
                {
                    await Navigation.PushAsync(new PoopPage
                    {
                        BindingContext = e.SelectedItem as Poop
                    });

                }

            }
        }
    }
}