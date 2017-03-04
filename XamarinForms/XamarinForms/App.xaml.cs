using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;
using XamarinForms.Services;
using XamarinForms.Helper;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinForms
{
    public partial class App : Application
    {
        public static IList<Kegler> KeglerList { get; set; } //Todo Löschen
        public static DataService dataService {get; set;}

        public App()
        {
            InitializeComponent();

            dataService = new DataService();

            KeglerList = new List<Kegler>();
            KeglerList.Add(new Kegler { _imageUri="bug_full.png", _vorname = "Katze 1", _nachname = "sjdksjd" });
            KeglerList.Add(new Kegler { _imageUri = "bug_seven.png", _vorname = "Katze 2", _nachname = "sjdksjd" });
            KeglerList.Add(new Kegler { _imageUri = "bug_six.png", _vorname = "Katze 3", _nachname = "sjdksjd" });
            KeglerList.Add(new Kegler { _imageUri = "bug_six.png", _vorname = "Katze 4", _nachname = "sjdksjd" });

            //Program p = new Program();
            
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