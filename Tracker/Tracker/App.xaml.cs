using Tracker.Data;
using Tracker.Views;
using Xamarin.Forms;


namespace Tracker
{
    public partial class App : Application
    {
        static TodoItemDatabase todoItemDB;
        static PoopDatabase poopDB;

        public App()
        {
            InitializeComponent();
            Resources = new ResourceDictionary();
            Resources.Add("primaryGreen", Color.FromHex("91CA47"));
            Resources.Add("darkPrimaryGreen", Color.FromHex("6FA22E"));

            var nav = new NavigationPage(new QuantityListPage());
            nav.BarBackgroundColor = (Color)App.Current.Resources["primaryGreen"];
            nav.BarTextColor = Color.White;
            MainPage = nav;
        }
        
        //public static BaseDatabase Database
        //{
        //    get
        //    {
        //        if (database == null)
        //        {
        //            database = new BaseDatabase();
        //        }
        //        return database;
        //    }
        //}
        public static TodoItemDatabase ToDoItemmDatabase
        {
            get
            {
                if (todoItemDB == null)
                {
                    todoItemDB = new TodoItemDatabase();
                }
                return todoItemDB;
            }
        }

        public static PoopDatabase PoopDatabase
        {

            get
            {
                if (poopDB == null)
                {
                    poopDB = new PoopDatabase();
                }
                return poopDB;
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
