using System.ComponentModel.DataAnnotations;
using APP_LAWYER.WEB.Attributes;

namespace APP_LAWYER.WEB.Views.ViewModels;

public class RegisterViewModel
{
    [Required(ErrorMessage = "Не указан номер телефона")]
    [DataType(DataType.PhoneNumber)]
    [KazakhstanPhoneNumber(ErrorMessage = "Номер телефона должен быть в формате +7 (XXX) XXX-XX-XX")]
    [Display(Name = "PhoneNumber.Label", ResourceType = typeof(Resources.Registration))]
    public string PhoneNumber { get; set; }

    [Required(ErrorMessage = "Не указан пароль")]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Display(Name = "Подтверждение пароля")]
    [Required(ErrorMessage = "Не указана проверка пароля")]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "Пароли не совпадают")]
    public string ConfirmPassword { get; set; }
}