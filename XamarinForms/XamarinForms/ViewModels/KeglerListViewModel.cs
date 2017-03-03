using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinForms.Services;

namespace XamarinForms.ViewModels
{
    public class KeglerListViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Kegler> _names;
        private DataService _dataService;
        private INavigation _navigation;

        public ICommand OpenAddKeglerViewCommand
        {
            get
            {
                return new Command(async () =>
                {
                    await _navigation.PushModalAsync(new AddKeglerView(_dataService));
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

        public KeglerListViewModel(DataService dataService, INavigation navigation)
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
