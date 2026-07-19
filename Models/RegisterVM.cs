using System.ComponentModel.DataAnnotations;
public class RegisterVM
{
    [Required(ErrorMessage = "Không được để trống")]
    public string UserName { get; set; }

    [Required (ErrorMessage = "Không được để trống")]
    [EmailAddress(ErrorMessage ="Email không hợp lệ")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Không được để trống")]
    [MinLength(9, ErrorMessage = "Số điện thoại phải có ít nhất 9 số")]
    [MaxLength(13, ErrorMessage = "Số điện thoại phải dưới 13 số")]
    // regex
    [RegularExpression(@"^[\d\s-]{9,13}$",ErrorMessage ="số điện thoại không hợp lệ")]

    public string Phone { get; set; }

}