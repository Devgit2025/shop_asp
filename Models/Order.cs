using System.ComponentModel.DataAnnotations;

namespace food_asp.Models
{
    public class Order
    {
        [Key]
        public int Order_Id { get; set; }

        [Required]
        public string Order_Date { get; set; }

        [Required]
        public string Order_Name { get; set; }

        [Required]
        public string Order_Email { get; set; }

        [Required]
        public string Order_Tel { get; set; }

        [Required]
        public string Order_Address { get; set; }

        [Required]
        public int Order_Price_Total { get; set; }

        [Required]
        public int Order_Cus_Id { get; set; }
    }
}
