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
        private Dictionary<string, Dictionary<Page, object>> Tables = new Dictionary<string, Dictionary<Page, object>>()
        {
            ["TodoItem"] = { [new TodoItemPage()] = new TodoItem() },
            ["Poop"] = { [new PoopPage()] = new Poop()}
        };

        private Dictionary<Page, object> PageTables = new Dictionary<Page, object>()
        {

        };
        private BaseDatabase baseDB = BaseDatabase.DB;
        public QuantityListPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await baseDB.GetAllTablesAsync();
        }

        async void OnQuantitySelected(object sender, SelectedItemChangedEventArgs e)
        {
            var all = Tables[sender.ToString()];
            var page = all.Keys.FirstOrDefault();
            var quantity = all.Values.FirstOrDefault();

            if(e.SelectedItem != null)
            {
                await Navigation.PushAsync(page
                {
                    BindingContext = e.SelectedItem as quantity
                });
            }
        }
    }
}