namespace ShopManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public partial class SupplierOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SupplierOrder()
        {
            SupplierOrderDetails = new HashSet<SupplierOrderDetail>();
        }

        public int SupplierOrderId { get; set; }

        [StringLength(50)]
        public string SupplierId { get; set; }

        [StringLength(255)]
        public string CompanyName { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalPaid { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DateOrder { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(20)]
        public string SearchOrderID { get; set; }

        public int? MainSupplierID { get; set; }

        [StringLength(50)]
        public string OrderNumber { get; set; }

        public string NoteDetails { get; set; }

        [Column(TypeName = "money")]
        public decimal? VATValue { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalVAT { get; set; }

        public string EmailAddress { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplierOrderDetail> SupplierOrderDetails { get; set; }
    }
}
