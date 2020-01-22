using Tracker.Data;
using Tracker.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Tracker
{
    public partial class App : Application
    {
        static BaseDatabase database;

        public App()
        {
            InitializeComponent();
            Resources = new ResourceDictionary();
            Resources.Add("primaryGreen", Color.FromHex("91CA47"));
            Resources.Add("darkPrimaryGreen", Color.FromHex("6FA22E"));

            var nav = new NavigationPage(new TodoListPage());
            nav.BarBackgroundColor = (Color)App.Current.Resources["primaryGreen"];
            nav.BarTextColor = Color.White;
            MainPage = nav;
        }

        public static BaseDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new BaseDatabase();
                }
                return database;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
