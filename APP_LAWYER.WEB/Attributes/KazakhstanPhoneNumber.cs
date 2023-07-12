using System.ComponentModel.DataAnnotations;

namespace APP_LAWYER.WEB.Attributes
{
    public class KazakhstanPhoneNumberAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var phoneNumber = value as string;
            if (!phoneNumber.StartsWith("+7"))
            {
                return new ValidationResult("Номер телефона должен начинаться с +7");
            }
            return ValidationResult.Success;
        }
    }
} 