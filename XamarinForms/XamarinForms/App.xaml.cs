using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;
using XamarinForms.Services;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinForms
{
    public partial class App : Application
    {
        public static DataService dataService {get; set;}

        public App()
        {
            InitializeComponent();

            dataService = new DataService();
            
            MainPage = new NavigationPage(new Pages.MainPage(dataService));
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