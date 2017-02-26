using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinForms
{
    public partial class App : Application
    {
        public static IList<Kegler> KeglerList { get; set; }

        public App()
        {
            InitializeComponent();

            KeglerList = new List<Kegler>();
            KeglerList.Add(new Kegler { imageName="bug_full.png", DisplayName = "Katze 1", Twitter = "sjdksjd" });
            KeglerList.Add(new Kegler { imageName = "bug_seven.png", DisplayName = "Katze 2", Twitter = "sjdksjd" });
            KeglerList.Add(new Kegler { imageName = "bug_six.png", DisplayName = "Katze 3", Twitter = "sjdksjd" });
            KeglerList.Add(new Kegler { imageName = "bug_six.png", DisplayName = "Katze 4", Twitter = "sjdksjd" });
            KeglerList.Add(new Kegler { imageName = "bug_six.png", DisplayName = "Katze 5", Twitter = "sjdksjd" });
            KeglerList.Add(new Kegler { imageName = "bug_six.png", DisplayName = "Katze 6", Twitter = "sjdksjd" });
            KeglerList.Add(new Kegler { imageName = "bug_six.png", DisplayName = "Katze 7", Twitter = "sjdksjd" });
            KeglerList.Add(new Kegler { imageName = "bug_six.png", DisplayName = "Katze 8", Twitter = "sjdksjd" });
            KeglerList.Add(new Kegler { imageName = "bug_six.png", DisplayName = "Katze 9", Twitter = "sjdksjd" });



            MainPage = new NavigationPage(new Pages.MainPage());
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