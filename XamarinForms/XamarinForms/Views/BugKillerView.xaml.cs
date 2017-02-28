using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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

        public BugKillerView(DataService _dataService)
        {
            InitializeComponent();
            dataService = _dataService;
            BindingContext = new BugKillerViewModel(_dataService, this.Navigation);
        }

        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
         => ((ListView)sender).SelectedItem = null;

        async void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var k = (Kegler)e.SelectedItem;
            change(k);
            
            await DisplayAlert("Selected", k._vorname, "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }

        void change(Kegler k)
        {
            dataService.UpdateImage(k);
        }
    }
}
