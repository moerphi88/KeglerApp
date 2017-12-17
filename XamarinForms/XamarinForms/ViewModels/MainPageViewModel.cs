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
using XamarinForms.Helpers;
using XamarinForms.Views;

namespace XamarinForms.ViewModels
{
    class MainPageViewModel : BaseViewModel
    { 
        public MainPageViewModel(DataService dataService, INavigation navigation) : base(dataService,navigation)
        {
            
        }

        public ICommand OpenBugKillerViewCommand
        {
            get
            {
                return new Command(async () =>
                {
                    _dataService.StartNewGame();
                    await _navigation.PushAsync(new BugKillerView(_dataService));
                });
            }
        }

        public ICommand ContinueBugKillerViewCommand
        {
            get
            {
                return new Command(async () =>
                {
                    _dataService.IsInitialRound = false;
                    await _navigation.PushAsync(new BugKillerView(_dataService));
                });
            }
        }

        public ICommand OpenKeglerListViewCommand
        {
            get
            {
                return new Command(async () =>
                {
                    await _navigation.PushAsync(new KeglerListView(_dataService));
                });
            }
        }

        private bool canAddPlayer = true;
        public bool CanAddPlayer
        {
            get
            {
                return canAddPlayer;
            }
            set
            {
                canAddPlayer = value;
                OnPropertyChanged();
            }
        }

        private bool canContinueGame = true;
        public bool CanContinueGame
        {
            get
            {
                return canContinueGame;
            }
            set
            {
                canContinueGame = value;
                OnPropertyChanged();
            }
        }

        public override void Update()
        {
            CanAddPlayer = _dataService.addingPlayerIsPossible;
            CanContinueGame = _dataService.continueGameIsPossible;
        }
    }

}
