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
            Employees.Add(new Employee { imageName="bug_full.png", DisplayName = "Katze 1", Twitter = "sjdksjd" });
            Employees.Add(new Employee { imageName = "bug_seven.png", DisplayName = "Katze 2", Twitter = "sjdksjd" });
            Employees.Add(new Employee { imageName = "bug_six.png", DisplayName = "Katze 3", Twitter = "sjdksjd" });

            MainPage = new NavigationPage(new MainPage());
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