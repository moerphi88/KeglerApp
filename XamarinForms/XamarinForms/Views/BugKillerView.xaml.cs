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

        async void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var k = (Kegler)e.SelectedItem;

            dataService.UpdateImage(k);

            dataService.UpdateList();

            // await DisplayAlert("Selected", k._vorname, "OK");
            //dataService.GetNames();

        }

       
    }
}
