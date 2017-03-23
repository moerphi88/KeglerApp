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
        public MainPageViewModel(DataService dataService, INavigation navigation) : base(dataService,navigation){}

        public ICommand OpenBugKillerViewCommand
        {
            get
            {
                return new Command(async () =>
                {
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

        private bool showButton = true;
        public bool ShowButton
        {
            get
            {
                return showButton;
            }

            set
            {
                showButton = value;
                OnPropertyChanged();
            }
        }

        public override void Update()
        {
            ShowButton = _dataService.IsButtonActive;
        }
    }

}
