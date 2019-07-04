using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ExerciciosScroll
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            HotReloader.Current.Start(this);

            MainPage = new PaisagensScroll();
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
