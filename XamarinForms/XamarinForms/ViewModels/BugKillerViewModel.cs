using Android.Views;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinForms.Services;

namespace XamarinForms.ViewModels
{
    public class BugKillerViewModel : INotifyPropertyChanged
    {
        private DataService _dataService;
        private INavigation _navigation;

        private ObservableCollection<Kegler> _names;
        public ICommand ItemTappedCommand { get; private set; }
        public ICommand ItemSelectedCommand { get; private set; }

        public ICommand AddKeglerCommand
        {
            get
            {
                return new Command(async()=>
                {
                    //Do something here
                    await _navigation.PushAsync(new AddKeglerView(_dataService));
                });
            }
        }

        public ObservableCollection<Kegler> Names
        {
            get
            {
                return _names;
            }

            set
            {
                _names = value;
                OnPropertyChanged();
            }
        }

        public BugKillerViewModel(DataService dataService, INavigation navigation)
        {
            _navigation = navigation;
            _dataService = dataService;

            Names = _dataService.GetNames();
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}


/*
 *  //Todo: Das muss noch als Command ins ViewModel gezogen werden!
        async void OnClickAddKegler(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddKeglerView(dataService));
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
 * */
