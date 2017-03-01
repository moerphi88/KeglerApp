using System;
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
            _names.Add(new Kegler { _initialWurf=0,_imageUri = "bug_full.png", _vorname = "Anja", _nachname = "SL" });
            _names.Add(new Kegler { _initialWurf = 1, _imageUri = "bug_full.png", _vorname = "Johannes", _nachname = "Watermann" });
        }
        
        
        public void AddNames(Kegler k)
        {
            _names.Add(k);
        }

        public ObservableCollection<Kegler> GetNames()
        {
            return _names;
        }

        public void UpdateImage(Kegler k)
        {
            foreach(Kegler name in _names)
            {
                name._imageUri = "bug_seven.png";
            }
        }

        public void UpdateList()
        {
            ObservableCollection<Kegler> temp = new ObservableCollection<Kegler>();

            foreach (Kegler item in _names)
            {
                temp.Add(item);
            }

            _names.Clear();

            foreach (Kegler item in temp)
            {
                _names.Add(item);
            }
        }
    }
}
