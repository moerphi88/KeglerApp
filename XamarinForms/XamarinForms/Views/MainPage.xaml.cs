using System;
using Xamarin.Forms;
using XamarinForms.Services;
using XamarinForms.ViewModels;
using XamarinForms.Views;

namespace XamarinForms.Pages
{
    public partial class MainPage : ContentPage
    {
        public DataService dataService { get; set; }
        private BaseViewModel vm { get; set; }
        
        public MainPage(DataService _dataService)
        {
            InitializeComponent();
            dataService = _dataService;

            vm = new MainPageViewModel(_dataService, this.Navigation);
            BindingContext = vm;  
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            vm.Update();
        }


    }
}