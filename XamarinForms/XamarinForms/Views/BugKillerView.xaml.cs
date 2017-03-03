using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms.Services;
using XamarinForms.ViewModels;

namespace XamarinForms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BugKillerView : ContentPage
    {
        DataService dataService;
        BugKillerViewModel vm;

        public BugKillerView(DataService _dataService)
        {
            InitializeComponent();
            dataService = _dataService;
            vm = new BugKillerViewModel(_dataService, this.Navigation);
            BindingContext = vm;
        }

        //Standard constructor
        public BugKillerView() { }

        void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

        }

        // Scheint iwie nicht zu funktionieren :(
        void Handle_KegelWurfEntry(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue != "")
            {
                int newValue = Convert.ToInt32(e.NewTextValue);
                try
                {
                    if (newValue < 0 || newValue > 9)
                    {
                        vm.KegelWurf = "0";
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.StackTrace);
                }
            } 

        }


    }
}
