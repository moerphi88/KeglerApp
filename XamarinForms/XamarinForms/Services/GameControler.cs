using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using XamarinForms.Interfaces;
using XamarinForms.Helpers;

namespace XamarinForms.Services
{
    public class GameControler
    {
        private ObservableCollection<Kegler> _names;
        private bool _isInitialRound;
        private int _activePlayer;
        private int _kegelWurf;
        private bool _gameIsAvtive;

        void StartGame()
        {
            throw new NotImplementedException();
        }

        void LoadGame()
        {
            throw new NotImplementedException();
        }

        void ContinueGame()
        {
            throw new NotImplementedException();
        }

        public GameControler(DataService dataService)
        {
            _names = dataService.GetNames();
            _isInitialRound = true;
            _activePlayer = 0;
            _kegelWurf = 0;
            _gameIsAvtive = false;

        }
        


    }
}
