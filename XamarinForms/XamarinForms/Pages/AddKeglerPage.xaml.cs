using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            BindingContext = new Page1ViewModel();
        }
    }

    class Page1ViewModel : INotifyPropertyChanged
    {

        public Page1ViewModel()
        {
            IncreaseCountCommand = new Command(async () => await IncreaseCountAsync());
        }

        string vorname = "Hans";
        string nachname = "Hansen";


        public ICommand IncreaseCountCommand { get; }

        public string Vorname
        {
            get
            {
                return vorname;
            }

            set
            {
                vorname = value;
                OnPropertyChanged();
            }
        }

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

        async Task IncreaseCountAsync()
        {
            await Task.Run(() => IncreaseCount());
        }

        void IncreaseCount()
        {
            App.KeglerList.Add(new Kegler { imageName = "bug_six.png", DisplayName = Vorname, Twitter = Nachname });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName]string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    }
}
