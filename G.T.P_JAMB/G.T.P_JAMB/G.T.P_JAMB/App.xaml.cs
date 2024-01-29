using G.T.P_JAMB.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace G.T.P_JAMB
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ListaTarea());
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
