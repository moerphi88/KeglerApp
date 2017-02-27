using System.Collections.Generic;
using System.Collections.ObjectModel;
using XamarinForms.Interfaces;

namespace XamarinForms.Services
{
    public class DataService : IDataServices
    {
        public ObservableCollection<Kegler> _names;

        public DataService()
        {
            _names = new ObservableCollection<Kegler>();
            _names.Add(new Kegler { _imageUri = "bug_full.png", _vorname = "Anja", _nachname = "SL" });
            _names.Add(new Kegler { _imageUri = "bug_full.png", _vorname = "Johannes", _nachname = "Watermann" });
        }
        

        public void AddNames(Kegler k)
        {
            _names.Add(k);
        }

        public ObservableCollection<Kegler> GetNames()
        {
            return _names;
        }

    }
}
