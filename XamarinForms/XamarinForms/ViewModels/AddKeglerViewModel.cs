﻿using System;
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

namespace XamarinForms.ViewModels
{
    class AddKeglerViewModel : BaseViewModel
    {
        public ICommand IncreaseCountCommand { get; }   

        public AddKeglerViewModel(DataService dataService, INavigation navigation) : base(dataService,navigation)
        {
            IncreaseCountCommand = new Command(async () => await AddKeglerAsync());
        }

        async Task AddKeglerAsync()
        {
            _dataService.AddNames(new Kegler { _isActive = false, _leben = 8, _initialWurf = 0, _imageUri = "bug_full.png", _vorname = Vorname, _nachname = Nachname });
            await _navigation.PopModalAsync();
        }

        public string Vorname
        {
            get
            {
                return Settings.Vorname;
            }

            set
            {
                if(Settings.Vorname == value)
                    return;
                Settings.Vorname = value;
                OnPropertyChanged();
            }
        }

        string nachname = "Hansen";
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

        public override void Update()
        {
            base.Update();
            //todo
        }
    }

}
