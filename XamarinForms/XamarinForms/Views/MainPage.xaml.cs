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
        
        public MainPage(DataService _dataService)
        {
            InitializeComponent();
            dataService = _dataService;
            BindingContext = new MainPageViewModel(_dataService, this.Navigation);
        }
        
    }
}