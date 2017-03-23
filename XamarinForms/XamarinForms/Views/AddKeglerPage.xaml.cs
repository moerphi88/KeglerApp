using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms.Services;
using XamarinForms.ViewModels;

namespace XamarinForms
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddKeglerView : ContentPage
    {
        private BaseViewModel vm { get; set; }

        public AddKeglerView(DataService _dataService)
        {
            InitializeComponent();
            vm = new AddKeglerViewModel(_dataService, this.Navigation);
            BindingContext = vm;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            vm.Update();
        }
    }
    
    
}
