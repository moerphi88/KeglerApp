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
        private BugKillerViewModel vm { get; set; }

        public BugKillerView(DataService _dataService)
        {
            InitializeComponent();
            dataService = _dataService;
            vm = new BugKillerViewModel(_dataService, this.Navigation);
            BindingContext = vm;
        }

        //Standard constructor
        public BugKillerView() { }

        // Workaround, weil ich den Picker nicht binden konnte. https://developer.xamarin.com/guides/xamarin-forms/user-interface/picker/populating-itemssource/
        void OnPickerSelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;

            if (selectedIndex != -1)
            {
                vm.KegelWurf = picker.Items[selectedIndex];
                //System.Diagnostics.Debug.WriteLine(picker.Items[selectedIndex]);
            }
        }

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

        protected override void OnAppearing()
        {
            base.OnAppearing();
            vm.Update();
        }
    }
}
