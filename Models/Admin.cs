using System.ComponentModel.DataAnnotations;

namespace food_asp.Models
{
    public class Admin
    {
        [Key]
        public int Admin_Id { get; set; }

        [Required]
        public string Admin_Username { get; set; }

        [Required]
        public string Admin_Password { get; set; }

        [Required]
        public string Admin_Fullname { get; set; }

        [Required]
        public string Admin_Tel { get; set; }

        [Required]
        public string Admin_Email { get; set; }
    }
}
