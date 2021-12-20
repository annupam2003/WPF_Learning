using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Validation_ByDataErrorInfo
{
    public class RegistrationVM : INotifyPropertyChanged, IDataErrorInfo
    {

        public Dictionary<string, string> ErrorsCollection { get; private set; } = new Dictionary<string, string>();
        public string this[string name]
        {
            get
            {
                string result = null;
                if (name == nameof(UserName))
                {
                    if (string.IsNullOrEmpty(UserName)) { result = "User Name can not be empity"; }
                    else if (UserName.Trim().Length < 5) { result = "Minimum 5 char required"; }
                }
                if (ErrorsCollection.ContainsKey(name))
                {
                    ErrorsCollection[name] = result;
                }
                else if (result != null)
                {
                    ErrorsCollection.Add(name, result);
                }
                
                OnPropertyChange("ErrorsCollection");
                return result;
            }
        }
        public string Error { get { return null; } }

        private string _username;
        public string UserName
        {
            get { return _username; }
            set
            {
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
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyChanged));
            }
        }
    }
}
