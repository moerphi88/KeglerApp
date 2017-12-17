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
                switch (_leben)
                {
                    case 8: ImageUri = "bug_full.png"; break;
                    case 7: ImageUri = "bug_seven.png"; break;
                    case 6: ImageUri = "bug_six.png"; break;
                    case 5: ImageUri = "bug_five.png"; break;
                    case 4: ImageUri = "bug_four.png"; break;
                    case 3: ImageUri = "bug_three.png"; break;
                    case 2: ImageUri = "bug_two.png"; break;
                    case 1: ImageUri = "bug_one.png"; break;
                    case 0: ImageUri = "bug_dead.png"; break;
                    default: _leben = 0; break;
                }
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
