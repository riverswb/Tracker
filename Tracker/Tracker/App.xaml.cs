using System;
using Tracker.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tracker
{
    public partial class App : Application
    {
        static TodoItemDatabase database;

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        public static TodoItemDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new TodoItemDatabase();
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
