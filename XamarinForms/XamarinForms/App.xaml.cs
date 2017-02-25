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
            Employees.Add(new Employee { visible_full = true, visible_seven = false, visible_six = false, DisplayName = "Katze 1", Twitter = "sjdksjd" });
            Employees.Add(new Employee { visible_full = false, visible_seven = true, visible_six = false, DisplayName = "Katze 2", Twitter = "sjdksjd" });
            Employees.Add(new Employee { visible_full = false, visible_seven = false, visible_six = true, DisplayName = "Katze 3", Twitter = "sjdksjd" });
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