using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace C_Validation_ByCustom
{
    public class RegistrationVM : INotifyPropertyChanged
    {
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
    public class TextBoxCustomRule: ValidationRule
    {
        public int MinimumLength { get; set; }
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string charString = value as string;
            if (charString.Length < MinimumLength)
            {
                return new ValidationResult(false, "Minimum length is five");
            }
            return new ValidationResult(true, null);
        }
    }
}
