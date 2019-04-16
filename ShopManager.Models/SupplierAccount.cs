namespace ShopManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public partial class SupplierAccount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SupplierAccount()
        {
            SupplierProducts = new HashSet<SupplierProduct>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string SupplierAc { get; set; }

        [StringLength(40)]
        public string CompanyName { get; set; }

        [StringLength(50)]
        public string ContactName { get; set; }

        [StringLength(60)]
        public string Address { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string Region { get; set; }

        [StringLength(50)]
        public string PostalCode { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        [StringLength(24)]
        public string Phone { get; set; }

        [StringLength(24)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string website { get; set; }

        [Column(TypeName = "ntext")]
        public string Note { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(94)]
        public string Name_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplierProduct> SupplierProducts { get; set; }
    }
}
