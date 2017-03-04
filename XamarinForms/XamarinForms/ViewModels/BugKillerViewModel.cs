using Android.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinForms.Services;
using System.Threading.Tasks;

namespace XamarinForms.ViewModels
{
    public class BugKillerViewModel : INotifyPropertyChanged
    {
        private DataService _dataService;
        private INavigation _navigation;

        private int _activeKegler = 0;
        private bool _isInitialRound = true;

        private ObservableCollection<Kegler> _names;

        private string kegelWurf = "0";
        public string KegelWurf
        {
            get
            {
                return kegelWurf;
            }

            set
            {
                kegelWurf = value;
                OnPropertyChanged();
            }
        }

        private bool _isRefreshing = false;
        public bool IsRefreshing
        {
            get { return _isRefreshing; }
            set
            {
                _isRefreshing = value;
                OnPropertyChanged(nameof(IsRefreshing));
            }
        }

        public ICommand NextClickedCommand
        {
            get
            {
                return new Command(NextKegler);
            }
        }

        async void NextKegler()
        {
            var wurf = Convert.ToInt32(KegelWurf);
            if (wurf >= 0 && wurf <= 9)
            {

                if (_isInitialRound)
                {
                    _names[_activeKegler]._initialWurf = Convert.ToInt32(kegelWurf);
                }
                if (!_isInitialRound) //Das Spiel beginnt!
                {
                    _names[_activeKegler]._isActive = true;
                    _dataService.EvaluateWurf(Convert.ToInt32(kegelWurf));
                }
                _activeKegler++;

                if (_isInitialRound && _activeKegler == Names.Count)
                {
                    //Irgendwann einmal ein Dialog hier anzeigen
                    var answer = await App.Current.MainPage.DisplayAlert("Initialrunde beendet!", "Möchtet Ihr die Runde nochmal machen?", "Yes", "No");
                    if (!answer) _isInitialRound = false;
                }

                if (_activeKegler >= Names.Count) _activeKegler = 0;

                _dataService.UpdateList();

                //If we start the activeKegler from the begining, we must set the last element of the list to not active. Otherwise we can take the last one with activeKegler - 1
                if (_activeKegler == 0) _names[Names.Count - 1]._isActive = false;
                else _names[_activeKegler - 1]._isActive = false;
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Halt! Stop!", "Wusstest du nicht, dass beim Kegeln nur 9 Kegel fallen können?! Angeber!", "Ok");
                KegelWurf = "0";
            }



        }

        public ICommand RefreshCommand
        {
            get
            {
                return new Command(async () =>
                {
                    IsRefreshing = true;

                    await Task.Run(() => _dataService.UpdateList());

                    IsRefreshing = false;
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


