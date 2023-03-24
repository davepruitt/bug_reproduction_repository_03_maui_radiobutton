using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioButtonBug
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        #region Private data members

        private bool radio_buttons_enabled = true;

        #endregion

        #region Constructor

        public MainPageViewModel()
        {
            //empty
        }

        #endregion

        #region Properties

        public bool IsRadioButtonEnabled
        {
            get
            {
                return radio_buttons_enabled;
            }
            set
            {
                radio_buttons_enabled = value;
                NotifyPropertyChanged("IsRadioButtonEnabled");
            }
        }

        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged (string property_name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property_name));
        }

        #endregion
    }
}
