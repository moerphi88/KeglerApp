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
        ObservableCollection<Kegler> GetNames();
        void AddNames(Kegler k);
        void EvaluateWurf(int wurf);
        void UpdateList();
        void DeleteName(Kegler k);
    }
}
