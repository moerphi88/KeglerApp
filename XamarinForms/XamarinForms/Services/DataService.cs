using System.Collections.Generic;
using System.Collections.ObjectModel;
using XamarinForms.Interfaces;

namespace XamarinForms.Services
{
    public class DataService : IDataServices
    {
        public ObservableCollection<string> _names;

        public DataService()
        {
            _names = new ObservableCollection<string>
            {
                "Mohammes", "Hassan", "ali", "Denis"
            };
        }
        

        public void AddNames(string s)
        {
            _names.Add(s);
        }

        public ObservableCollection<string> GetNames()
        {
            return _names;
        }

    }
}
