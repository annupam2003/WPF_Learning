using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Validation_ByAnnotation
{
    public class RegistrationVM : INotifyPropertyChanged
    {
        private string _username;

        [Required(ErrorMessage ="User Name must required")]
        [StringLength(100,MinimumLength = 5,ErrorMessage ="mininmum length 5")]
        public string UserName
        {
            get { return _username; }
            set
            {
                _username = value;
                ValidateProperty(value, nameof(UserName));                
                this.OnPropertyChange(nameof(UserName));
            }
        }

        private void ValidateProperty<T>(T value,string name)
        {
            Validator.ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = name });
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
