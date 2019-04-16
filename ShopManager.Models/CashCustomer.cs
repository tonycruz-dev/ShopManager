namespace ShopManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
 
    public partial class CashCustomer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CashCustomer()
        {
            CashInvoices = new HashSet<CashInvoice>();
        }

        [Key]
        [StringLength(50)]
        public string CustomerAc { get; set; }

        [StringLength(50)]
        public string CompanyName { get; set; }

        [StringLength(50)]
        public string ContactName { get; set; }

        [StringLength(50)]
        public string Address1 { get; set; }

        [StringLength(50)]
        public string address2 { get; set; }

        [StringLength(50)]
        public string address3 { get; set; }

        [StringLength(50)]
        public string Address4 { get; set; }

        [StringLength(50)]
        public string address5 { get; set; }

        [StringLength(50)]
        public string PostCode { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string WebPage { get; set; }

        public string NotePad { get; set; }

        public float? CustomersDiscount { get; set; }

        public bool? Discontinued { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CashInvoice> CashInvoices { get; set; }
    }
}
