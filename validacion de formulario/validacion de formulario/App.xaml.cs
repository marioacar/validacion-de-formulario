using System;
using validacion_de_formulario.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace validacion_de_formulario
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Formulario());
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
