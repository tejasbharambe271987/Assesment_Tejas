using System;
using AssesmentTejas.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Assesment_Tejas
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new PeopleList());
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
