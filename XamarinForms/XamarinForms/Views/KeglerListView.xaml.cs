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
        public KeglerListView(DataService _dataService)
        {
            InitializeComponent();
            BindingContext = new KeglerListViewModel(_dataService);
        }
    }
}
