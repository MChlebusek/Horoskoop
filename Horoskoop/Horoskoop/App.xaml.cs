using Horoskoop.Services;
using Horoskoop.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Horoskoop
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new StartPage());
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
