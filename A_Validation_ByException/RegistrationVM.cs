using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Validation_ByException
{
    public class RegistrationVM :INotifyPropertyChanged
    {
        private string _username;

        public string UserName
        {
            get { return _username; }
            set {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("User Name can not be empity");
                }
                else
                {
                    _username = value;
                }
                this.OnPropertyChange(nameof(UserName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChange(string propertyChanged)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if(handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyChanged));
            }
        }
    }
}
