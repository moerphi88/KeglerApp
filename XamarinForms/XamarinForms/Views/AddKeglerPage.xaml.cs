using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms.Services;
using XamarinForms.ViewModels;

namespace XamarinForms
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddKeglerView : ContentPage
    {
        public AddKeglerView(DataService _dataService)
        {
            InitializeComponent();
            BindingContext = new AddKeglerViewModel(_dataService, this.Navigation);
        }
    }
    
    
}
