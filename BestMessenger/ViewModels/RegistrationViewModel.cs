using BestMessenger.Infrastructure.Commands;
using BestMessenger.Infrastructure.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BestMessenger.ViewModels
{
    public class ValidProperty
    {
        public string FieldName;
        public string Value { get; set; }
        public ValidateType[] ValidateTypes { get; set; }
        public bool IsValid { get; set; } = true;
    }

    public class RegistrationViewModel : BaseViewModel
    {
        #region Properties
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { UpdateValue(ref firstName, value); }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { UpdateValue(ref lastName, value); }
        }

        private string nickName;

        public string NickName
        {
            get { return nickName; }
            set { UpdateValue(ref nickName, value);}
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { UpdateValue(ref email, value); }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { UpdateValue(ref password, value); }
        }

        private bool nameValid = true;
        public bool NameValid
        {
            get { return nameValid; }
            set { UpdateValue(ref nameValid, value); }
        }

        private bool lastNameValidate = true;
        public bool LastNameValidate
        {
            get { return lastNameValidate; }
            set { UpdateValue(ref lastNameValidate, value); }
        }


        private ValidationUtils _validationUtils;
        #endregion

        #region Commands
        public ActionCommand RegistrationCommand => new ActionCommand(x => ValidateProperties());
        #endregion

        public RegistrationViewModel()
        {
            _validationUtils = new ValidationUtils();
        }
        private void ValidateProperties()
        {
            List<ValidProperty> validProperties = new List<ValidProperty>()
            {
                new ValidProperty() { Value = FirstName, ValidateTypes = new ValidateType[]{ ValidateType.EmptyStr, ValidateType.DigitalConstains }, FieldName = nameof(NameValid)}
            };
            _validationUtils.IsValid(validProperties);
            foreach (var item in validProperties)
            {
                if(item.FieldName == nameof(NameValid))
                    NameValid = item.IsValid;
            }
        }
    }
}
