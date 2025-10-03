using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace food_asp.Models
{
    public class Customer
    {
        [Key]
        public int Cus_Id { get; set; }

        [Required]
        [DisplayName("Username")]
        public string Cus_Username { get; set; }

        [Required]
        [DisplayName("Password")]
        public string Cus_Password { get; set; }

        [Required]
        [DisplayName("Fullname")]
        public string Cus_Fullname { get; set; }

        [Required]
        [DisplayName("Tel")]
        public string Cus_Tel { get; set; }

        [Required]
        [DisplayName("Email")]
        public string Cus_Email { get; set; }
    }
}
