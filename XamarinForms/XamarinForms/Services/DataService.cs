using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using XamarinForms.Interfaces;
using XamarinForms.Helpers;

namespace XamarinForms.Services
{
    public class DataService : IDataServices
    {
        public DataService()
        {
            var list = JsonConvert.DeserializeObject<ObservableCollection<Kegler>>(Settings.KeglerList);
            if (list != null)
                _names = list;
            else
            {
                _names = new ObservableCollection<Kegler>();
                _names.Add(new Kegler { _isActive = false, Leben = 8, InitialWurf = 0, ImageUri = "bug_full.png", _vorname = "Anja", _nachname = "SL" });
                _names.Add(new Kegler { _isActive = false, Leben = 8, InitialWurf = 0, ImageUri = "bug_full.png", _vorname = "Johannes", _nachname = "Watermann" });
                Settings.KeglerList = JsonConvert.SerializeObject(_names);
            }
        }

        public ObservableCollection<Kegler> _names;

        private bool buttonIsActive = false;
        public bool IsButtonActive {
            get {
                buttonIsActive = !buttonIsActive;
                return buttonIsActive;
            }
            set
            {
                buttonIsActive = value;
            }
        }

        private bool _isInitialRound = true;
        public bool IsInitialRound
        {
            get { return _isInitialRound; }
            set { _isInitialRound  = value; }
        }

        public ObservableCollection<Kegler> GetNames()
        {
            return _names;
        }

        public void AddNames(Kegler k)
        {
            _names.Add(k);
            Settings.KeglerList = JsonConvert.SerializeObject(_names);
        }

        public void DeleteName(Kegler k)
        {
            _names.Remove(k);
            Settings.KeglerList = JsonConvert.SerializeObject(_names);
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
                        kegler.Leben--;
                        ChangeImage(kegler);
                    }
                }

            }
            else
            {
                //Normaler Wurf
                foreach (Kegler kegler in _names)
                {
                    if (kegler.InitialWurf == wurf)
                    {
                        kegler.Leben--;
                        ChangeImage(kegler);
                    }
                }
            }
        }

        private void ChangeImage(Kegler kegler)
        {
            switch (kegler.Leben)
            {
                case 8: kegler.ImageUri = "bug_full.png"; break;
                case 7: kegler.ImageUri = "bug_seven.png"; break;
                case 6: kegler.ImageUri = "bug_six.png"; break;
                case 5: kegler.ImageUri = "bug_five.png"; break;
                case 4: kegler.ImageUri = "bug_four.png"; break;
                case 3: kegler.ImageUri = "bug_three.png"; break;
                case 2: kegler.ImageUri = "bug_two.png"; break;
                case 1: kegler.ImageUri = "bug_one.png"; break;
                case 0: kegler.ImageUri = "bug_dead.png"; break;
                default: kegler.Leben = 0; break;
            }
        }

        public void StartNewGame()
        {
            //set each Kegler to its default parameter
            foreach(Kegler k in _names)
            {
                k.ImageUri = "bug_full.png";
                k._isActive = false;
                k.Leben = 8;
                k.InitialWurf = 0;
            }
            IsInitialRound = true;
        }

        public void SaveGame()
        {
            throw new NotImplementedException();
        }

    }
}
