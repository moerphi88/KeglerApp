using System;
using Xamarin.Forms;

namespace XamarinForms.Pages
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnClickStartBugKillerGame(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BugKillerPage());

        }

        async void OnClickAddKegler(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KeglerListPage());

        }
        


    }
}