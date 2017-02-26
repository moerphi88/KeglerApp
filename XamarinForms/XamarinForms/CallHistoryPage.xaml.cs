using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CallHistoryPage : ContentPage
    {
        public CallHistoryPage()
        {
            InitializeComponent();
        }

        async void OnClick(object sender, EventArgs e)
        {
            await DisplayAlert("Clicked!", "The button labeled has been clicked", "OK");
            App.Employees.Add(new Employee { imageName = "bug_six.png", DisplayName = "Katze 9", Twitter = "sjdksjd" });
        }
    }
}
