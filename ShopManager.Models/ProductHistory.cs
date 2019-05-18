using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ShopManager.Models
{
    [Table("ProductCategories")]
    public class ProductHistory
    {
        [Key]
        public int Id { get; set; }

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string ProductCode { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitCost { get; set; }

        public string Specifications { get; set; }
        public DateTime DateAction { get; set; }

        public string BarCode { get; set; }

    }
}
