namespace ShopManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            SupplierProducts = new HashSet<SupplierProduct>();
        }

        public int ProductID { get; set; }

        [Required]
        public string ProductName { get; set; }

        [StringLength(50)]
        public string ProductCode { get; set; }

        public int CategoryID { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitCost { get; set; }

        public int? QtyInStock { get; set; }

        public int? QtySold { get; set; }

        public int? QtyOnOrder { get; set; }

        public int? Sortage { get; set; }

        public bool Discontinued { get; set; }

        public string Specifications { get; set; }

        public string ContentDetails { get; set; }

        public DateTime? DateUpdated { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public float? Discount { get; set; }

        [StringLength(50)]
        public string GroupName { get; set; }

        public float? SupplierDiscount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplierProduct> SupplierProducts { get; set; }
    }
}
