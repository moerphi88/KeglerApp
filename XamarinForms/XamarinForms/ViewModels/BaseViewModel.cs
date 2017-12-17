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
using XamarinForms.Interfaces;

namespace XamarinForms.ViewModels
{
    class BaseViewModel : INotifyPropertyChanged
    {
        protected DataService _dataService { get; set; }
        protected INavigation _navigation { get; }   

        protected BaseViewModel(DataService dataService, INavigation navigation)
        {
            _dataService = dataService;
            _navigation = navigation;
        }
        
        public virtual void Update()
        {
        }

        #region INotifyPropertyChanges Handler

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName]string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); 
        #endregion

    }

}
