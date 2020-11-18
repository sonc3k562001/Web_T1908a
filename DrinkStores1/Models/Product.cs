using System.ComponentModel.DataAnnotations.Schema;

namespace DrinkStores.Models
{
    public class Product
    {
        public long ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public decimal Price { get; set; }
        [Column(TypeName ="decimal(8,2)")]
        public double Discount { get; set; }
        public string Status { get; set; }
    }
}
