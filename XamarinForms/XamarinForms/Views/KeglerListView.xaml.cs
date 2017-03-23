using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms.Services;
using XamarinForms.ViewModels;

namespace XamarinForms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KeglerListView : ContentPage
    {
        DataService dataService;
        private BaseViewModel vm { get; set; }

        public KeglerListView(DataService _dataService)
        {
            InitializeComponent();
            dataService = _dataService;
            vm = new KeglerListViewModel(_dataService, this.Navigation);
            BindingContext = vm;
        }

        public void OnDelete(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            var kegler = (Kegler)mi.CommandParameter;
            dataService.DeleteName(kegler);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            vm.Update();
        }
    }
}
