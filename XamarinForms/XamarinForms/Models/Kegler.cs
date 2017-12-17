using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XamarinForms
{
    /*
     * _imageUri: bug_full.png, bug_seven.png, bug_six.png ....
     * _leben: 8 - 0
     * */

    public class Kegler : INotifyPropertyChanged
    {
        private string _imageUri;
        public string ImageUri
        {
            get
            {
                return _imageUri;
            }
            set
            {
                _imageUri = value;
                OnPropertyChanged();
            }
        }
        public string _vorname { get; set; }
        public string _nachname { get; set; }
        private int _initialWurf;
        public int InitialWurf
        {
            get
            {
                return _initialWurf;
            }
            set
            {
                _initialWurf = value;
                OnPropertyChanged();
            }
        }
        private int _leben;
        public int Leben
        {
            get
            {
                return _leben;
            }
            set
            {
                _leben = value;
                OnPropertyChanged();
            }
        }

        public bool _isActive { get; set; }

        #region INotifyPropertyChanges Handler

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName]string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        #endregion

    }
}
