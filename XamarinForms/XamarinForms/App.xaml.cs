using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinForms
{
    public partial class App : Application
    {
        public static IList<Employee> Employees { get; set; }

        public App()
        {
            InitializeComponent();
            Employees = new List<Employee>();
            Employees.Add(new Employee { ImageUri = "XamarinForms.kitten1.jpg", DisplayName = "Katze 1", Twitter = "sjdksjd" });
            Employees.Add(new Employee { ImageUri = "http://ak.scr.imgfarm.com/cats/md/SuperStock_1566-0148948.jpg", DisplayName = "Katze 2", Twitter = "sjdksjd" });
            Employees.Add(new Employee { ImageUri = "http://ak.scr.imgfarm.com/cats/md/SuperStock_1566-0148948.jpg", DisplayName = "Katze 3", Twitter = "sjdksjd" });
            MainPage = new NavigationPage(new CallHistoryPage());
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