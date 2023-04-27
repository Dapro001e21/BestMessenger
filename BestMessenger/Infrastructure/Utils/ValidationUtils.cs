using BestMessenger.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestMessenger.Infrastructure.Utils
{
    public enum ValidateType
    {
        EmptyStr,
        DigitalConstains,
        SpecialSymb,
        IsEmailValidate
    }

    public class ValidationUtils
    {
        public static event Action<ValidProperty> Validate;
        public ValidationUtils()
        {

        }

        public void IsValid(List<ValidProperty> properties)
        {
            for (int i = 0; i < properties.Count; i++)
            {
                if (properties[i].ValidateTypes.Contains(ValidateType.EmptyStr))
                {
                    Validate += EmptyStrValidate;
                }
                if (properties[i].ValidateTypes.Contains(ValidateType.DigitalConstains))
                {
                    Validate += DigitConstainslValidate;
                }
                if (properties[i].ValidateTypes.Contains(ValidateType.SpecialSymb))
                {
                    Validate += SpecialSymbValidate;
                }
                if (properties[i].ValidateTypes.Contains(ValidateType.IsEmailValidate))
                {
                    Validate += IsEmailValidate;
                }

                if(Validate != null)
                {
                    Validate(properties[i]);
                }
            }
        }

        private void EmptyStrValidate(ValidProperty property)
        {
            if (property.Value == null || property.Value.Length == 0)
            {
                property.IsValid = false;
            }
        }

        private void DigitConstainslValidate(ValidProperty property)
        {
            if (property.Value == null)
            {
                property.IsValid = false;
                return;
            }

            foreach (var item in property.Value)
            {
                if (Char.IsDigit(item))
                {
                    property.IsValid = false;
                }
            }
        }
        private void SpecialSymbValidate(ValidProperty property)
        {
            if (property.Value == null)
            {
                property.IsValid = false;
                return;
            }

            foreach (var item in property.Value)
            {
                if (item == '^')
                {
                    property.IsValid = false;
                }
            }
        }

        private void IsEmailValidate(ValidProperty property)
        {
            if(property.Value == null)
            {
                property.IsValid = false;
                return;
            }

            bool flag = false;
            foreach (var item in property.Value)
            {
                if (item == '@')
                {
                    flag = true;
                }
            }
            if(flag != true) property.IsValid = false;
        }

    }
}
