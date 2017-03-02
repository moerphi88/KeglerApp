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
            _names.Add(new Kegler { _isActive = false, _leben = 8, _initialWurf = 0, _imageUri = "bug_full.png", _vorname = "Anja", _nachname = "SL" });
            _names.Add(new Kegler { _isActive = false, _leben = 8, _initialWurf = 0, _imageUri = "bug_full.png", _vorname = "Johannes", _nachname = "Watermann" });
        }


        public void AddNames(Kegler k)
        {
            _names.Add(k);
        }

        public ObservableCollection<Kegler> GetNames()
        {
            return _names;
        }

        public void EvaluateWurf(int wurf)
        {
            //Pudel
            if (wurf == 0)
            {
                foreach (Kegler kegler in _names)
                {
                    if (kegler._isActive)
                    {
                        kegler._leben--;
                        ChangeImage(kegler);
                    }
                }

            }
            else
            {
                //Normaler Wurf
                foreach (Kegler kegler in _names)
                {
                    if (kegler._initialWurf == wurf)
                    {
                        kegler._leben--;
                        ChangeImage(kegler);
                    }
                }
            }
        }

        private void ChangeImage(Kegler kegler)
        {
            switch (kegler._leben)
            {
                case 8: kegler._imageUri = "bug_full.png"; break;
                case 7: kegler._imageUri = "bug_seven.png"; break;
                case 6: kegler._imageUri = "bug_six.png"; break;
                case 5: kegler._imageUri = "bug_five.png"; break;
                case 4: kegler._imageUri = "bug_four.png"; break;
                case 3: kegler._imageUri = "bug_three.png"; break;
                case 2: kegler._imageUri = "bug_two.png"; break;
                case 1: kegler._imageUri = "bug_one.png"; break;
                case 0: kegler._imageUri = "bug_dead.png"; break;
                default: kegler._leben = 0; break;
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
