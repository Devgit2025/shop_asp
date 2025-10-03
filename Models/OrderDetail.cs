using System.ComponentModel.DataAnnotations;

namespace food_asp.Models
{
    public class OrderDetail
    {
        [Key]
        public int Order_Id_Detail { get; set; }

        [Required]
        public int Order_Id { get; set; }

        [Required]
        public int Pro_Id { get; set; }

        [Required]
        public string Pro_Name { get; set; }

        [Required]
        public int Pro_Price { get; set; }

        [Required]
        public int Order_Quantity { get; set; }

        [Required]
        public int Order_Price_Total { get; set; }
    }
}
