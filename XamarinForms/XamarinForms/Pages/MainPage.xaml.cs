using System;
using Xamarin.Forms;
using XamarinForms.Services;
using XamarinForms.Views;

namespace XamarinForms.Pages
{
    public partial class MainPage : ContentPage
    {
        public DataService dataService { get; set; }
        
        public MainPage(DataService _dataService)
        {
            InitializeComponent();
            dataService = _dataService;
        }

        async void OnClickStartBugKillerGame(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BugKillerView(dataService));

        }

        async void OnClickAddKegler(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KeglerListView(dataService));

        }
        


    }
}