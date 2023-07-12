using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace APP_LAWYER.WEB.Attributes
{
    public class KazakhstanPhoneNumberAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var phoneNumber = value as string;
            if (!Regex.IsMatch(phoneNumber, @"^\+7\d{10}$"))
            {
                return new ValidationResult("Номер телефона должен быть в формате +7XXXXXXXXXX");
            }
            return ValidationResult.Success;
        }
    }
} 