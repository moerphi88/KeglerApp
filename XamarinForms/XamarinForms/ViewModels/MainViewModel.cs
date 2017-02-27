using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using XamarinForms.Services;

namespace XamarinForms.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private List<string> _names;

        public List<string> Names
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

        public MainViewModel(DataService _dataService)
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
