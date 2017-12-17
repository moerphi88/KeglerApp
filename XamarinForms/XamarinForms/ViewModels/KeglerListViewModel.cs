using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinForms.Services;

namespace XamarinForms.ViewModels
{
    class KeglerListViewModel : BaseViewModel
    {
        private ObservableCollection<Kegler> _names;

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

        public KeglerListViewModel(DataService dataService, INavigation navigation) : base(dataService, navigation)
        {
            Names = _dataService.GetNames();
        }
    }
}
