using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PRADExamen.Controllers;
using System.IO;
using PRADExamen.Views;

namespace PRADExamen
{
    public partial class App : Application
    {
        static Database db;

        public static Database InitDB
        {
            get
            {
                if (db == null)
                {
                    db = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "EXAM.exam"));
                }

                return db;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PageContent());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
