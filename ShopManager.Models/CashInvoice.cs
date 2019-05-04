namespace ShopManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("CashInvoice")]
    public partial class CashInvoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CashInvoice()
        {
            CashInvoiceDetails = new HashSet<CashInvoiceDetail>();
        }

        [Key]
        public int InvoiceID { get; set; }

        public int? InvoiceNum { get; set; }

        [StringLength(50)]
        public string CustomerAC { get; set; }

        [StringLength(255)]
        public string InvoiceAddress { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? InvoiceDate { get; set; }

        public float? Discount { get; set; }

        [Column(TypeName = "money")]
        public decimal? PostPacking { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalValue { get; set; }

        [Column(TypeName = "money")]
        public decimal? VATValue { get; set; }

        public bool InvoiceYesNo { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalVAT { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalPaid { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DatePaid { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DatePosted { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(20)]
        public string SearchInvoiceID { get; set; }

        [StringLength(20)]
        public string OrderNumber { get; set; }

        [StringLength(255)]
        public string JobAddress { get; set; }

        public string EmailAddress { get; set; }

        [Column(TypeName = "money")]
        public decimal? Deposite { get; set; }

        public bool? IsCash { get; set; }

        public bool? IsCard { get; set; }

        public bool? IsCheque { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(25)]
        public string InvoiceNumCount { get; set; }

        [StringLength(20)]
        public string DateInvoiceNum { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(6)]
        public string PaymentDisplay { get; set; }

        public bool? IsClosed { get; set; }

        public virtual CashCustomer CashCustomer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CashInvoiceDetail> CashInvoiceDetails { get; set; }
    }
}
