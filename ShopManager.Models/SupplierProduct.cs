namespace ShopManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
 

    public partial class SupplierProduct
    {
        public int SupplierProductId { get; set; }

        public int SupplierId { get; set; }

        public int ProductId { get; set; }

        [Column(TypeName = "money")]
        public decimal? CostPrice { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DateUpdate { get; set; }

        public virtual Product Product { get; set; }

        public virtual SupplierAccount SupplierAccount { get; set; }
    }
}
