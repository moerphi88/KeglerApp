using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinForms.Services;

namespace XamarinForms.ViewModels
{
    class AddKeglerViewModel : INotifyPropertyChanged
    {
        public DataService dataService { get; set; }

        public AddKeglerViewModel(DataService _dataService)
        {
            IncreaseCountCommand = new Command(async () => await IncreaseCountAsync());
            dataService = _dataService;
        }

        string vorname = "Hans";
        string nachname = "Hansen";

        public ICommand IncreaseCountCommand { get; }

        public string Vorname
        {
            get
            {
                return vorname;
            }

            set
            {
                vorname = value;
                OnPropertyChanged();
            }
        }

        public string Nachname
        {
            get
            {
                return nachname;
            }

            set
            {
                nachname = value;
                OnPropertyChanged();
            }
        }

        async Task IncreaseCountAsync()
        {
            await Task.Run(() => IncreaseCount());
        }

        void IncreaseCount()
        {
            dataService.AddNames(Vorname + Nachname);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName]string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    }

}
