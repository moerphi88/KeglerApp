using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinForms.Interfaces
{
    interface IDataServices
    {
        ObservableCollection<string> GetNames();
        void AddNames(string s);
    }
}
