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
            BindingContext = new KeglerListViewModel(_dataService);
        }

        //Todo: Das muss noch als Command ins ViewModel gezogen werden!
        async void OnClickAddKegler(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddKeglerView(dataService));
        }
    }
}
