using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using XamarinForms.Services;

namespace XamarinForms.ViewModels
{
    public class BugKillerViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Kegler> _names;

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

        public BugKillerViewModel(DataService _dataService)
        {
            var dataService = _dataService;

            Names = dataService.GetNames();
        }

 
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
