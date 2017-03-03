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

        public KeglerListView(DataService _dataService)
        {
            InitializeComponent();
            dataService = _dataService;
            BindingContext = new KeglerListViewModel(_dataService, this.Navigation);
        }

        public void OnMore(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            //DisplayAlert("More Context Action", mi.CommandParameter + " more context action", "OK");
        }

        public void OnDelete(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            var kegler = (Kegler)mi.CommandParameter;
            dataService.DeleteName(kegler);
            //DisplayAlert("Delete Context Action", mi.CommandParameter + " delete context action", "OK");
        }
    }
}
