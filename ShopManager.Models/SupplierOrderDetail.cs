namespace ShopManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public partial class SupplierOrderDetail
    {
        public int SupplierOrderDetailId { get; set; }

        public int SupplierOrderId { get; set; }

        public string Descriptions { get; set; }

        [StringLength(50)]
        public string ProductId { get; set; }

        [StringLength(50)]
        public string ProductCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? UnitPrice { get; set; }

        public int? Quantity { get; set; }

        [Column(TypeName = "money")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal TotalLine { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalPrice { get; set; }

        public float? Discount { get; set; }

        [Column(TypeName = "money")]
        public decimal? SalesPrice { get; set; }

        public virtual SupplierOrder SupplierOrder { get; set; }
    }
}
