using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using B2CXamarin.Services;
using B2CXamarin.Views;
using B2CXamarin.Services.Logon;

namespace B2CXamarin
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<B2CAuthenticationService>();
            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
