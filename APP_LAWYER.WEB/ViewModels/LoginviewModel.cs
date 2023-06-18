using System.ComponentModel.DataAnnotations;

namespace APP_LAWYER.WEB.Views.ViewModels;

public class LoginviewModel
{
    [Required(ErrorMessage = "Не указан телефон")]
    [DataType(DataType.PhoneNumber)]
    public string PhoneNumber { get; set; }

    [Required(ErrorMessage = "Не указан пароль")]
    [DataType(DataType.Password)]
    public string Password { get; set; }
}