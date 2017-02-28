using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            change(k);

            // await DisplayAlert("Selected", k._vorname, "OK");
            //dataService.GetNames();

        }

        void change(Kegler k)
        {
            dataService.UpdateImage(k);
            ObservableCollection<Kegler> temp = new ObservableCollection<Kegler>();
            foreach (Kegler item in vm.Names)
            {
                temp.Add(item);
            }
            vm.Names.Clear();
            vm.Names = temp; // Hier muss ich nochmal versuchen nicht die ViewModel Names sondern meine allgemeinen Daten zu aktualisieren!
        }
    }
}
