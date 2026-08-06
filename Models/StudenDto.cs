using System.ComponentModel.DataAnnotations;

namespace buoi18
{
    public class StudentDto
    {
       [ Required(ErrorMessage ="Vui long nhap ma sv")]
        public string MaSV { get; set; }
               [ Required(ErrorMessage ="Vui long nhap Ho Ten sv")]

        public string HoTen { get; set; }
               [ EmailAddress(ErrorMessage ="Vui long nhap mail  hop le")]

        public string Email { get; set; }
        public string SoDT { get; set; }
        public string CMND { get; set; }
        public int DiemToan { get; set; }
        public int DiemLy { get; set; }
        public int DiemHoa { get; set; }
    }
}
