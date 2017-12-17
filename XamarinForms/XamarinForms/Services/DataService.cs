using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using XamarinForms.Interfaces;
using XamarinForms.Helpers;

namespace XamarinForms.Services
{
    //Aktuell ist der DataService noch mein einziger Service. Er befüllt die Kegler Liste und wird auch benutzt um Kegler hinzuzufügen bzw. zu löschen. 
    //Außerdem wird hier noch jeder 
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

        public bool addingPlayerIsPossible = true;
        public bool continueGameIsPossible = false;
        private bool gameIsActive = false;

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

        // EvaluateWurf beinhaltet die Spielregeln
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
                    }
                }
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
