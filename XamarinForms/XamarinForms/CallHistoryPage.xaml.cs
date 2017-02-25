using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CallHistoryPage : ContentPage
    {
        public CallHistoryPage()
        {
            InitializeComponent();
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return; //ItemSelected is called on deselection, which results in SelectedItem being set to null
            }
            //App.Employees.Clear();
            //App.Employees.Add(new Employee { id = 0, visible_full = true, visible_seven = true, visible_six = false, DisplayName = "Katze 1", Twitter = "sjdksjd" });

            //var employee = (Employee)e.SelectedItem;
            //updateListItem(employee);
        }

        private bool updateListItem(Employee e)
        {
            var list = App.Employees;
            var idx = list.IndexOf(e);
            var item = e;
            //var test = (item.visible_full == true) ? (item.visible_full = false) : (item.visible_full = true);
            list.Insert(idx, item);
            list.RemoveAt(idx + 1);
            App.Employees = list;
            return true;
        }

    }
}
