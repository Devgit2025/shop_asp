using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace food_asp.Models
{
    public class Customer
    {
        [Key]
        public int Cus_Id { get; set; }

        [Required(ErrorMessage = "กรุณาป้อนชื่อผู้ใช้")]
        [DisplayName("Username")]
        public string Cus_Username { get; set; }

        [Required(ErrorMessage = "กรุณาป้อนรหัสผ่าน")]
        [DisplayName("Password")]
        public string Cus_Password { get; set; }

        [Required(ErrorMessage = "กรุณาป้อนชื่อเต็ม")]
        [DisplayName("Fullname")]
        public string Cus_Fullname { get; set; }

        [Required(ErrorMessage = "กรุณาป้อนเบอร์โทรศัพท์")]
        [DisplayName("Tel")]
        public string Cus_Tel { get; set; }

        [Required(ErrorMessage = "กรุณาป้อนอีเมล์")]
        [DisplayName("Email")]
        public string Cus_Email { get; set; }
    }
}
