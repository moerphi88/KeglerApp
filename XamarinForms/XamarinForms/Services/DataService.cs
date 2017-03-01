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
            _names.Add(new Kegler { _leben = 8, _initialWurf=0,_imageUri = "bug_full.png", _vorname = "Anja", _nachname = "SL" });
            _names.Add(new Kegler { _leben = 8, _initialWurf = 1, _imageUri = "bug_full.png", _vorname = "Johannes", _nachname = "Watermann" });
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
                if (name == k)

                    if(name._leben >= 0) name._leben = name._leben - 1;
                
                    switch (name._leben)
                    {
                        case 8: name._imageUri = "bug_full.png"; break;
                        case 7: name._imageUri = "bug_seven.png"; break;
                        case 6: name._imageUri = "bug_six.png"; break;
                        case 5: name._imageUri = "bug_five.png"; break;
                        case 4: name._imageUri = "bug_four.png"; break;
                        case 3: name._imageUri = "bug_three.png"; break;
                        case 2: name._imageUri = "bug_two.png"; break;
                        case 1: name._imageUri = "bug_one.png"; break;
                        case 0: name._imageUri = "bug_dead.png"; break;
                    }
                    
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
