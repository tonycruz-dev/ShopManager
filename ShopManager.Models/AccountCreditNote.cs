namespace ShopManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("AccountCreditNote")]
    public partial class AccountCreditNote
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AccountCreditNote()
        {
            AccountCreditNoteDetails = new HashSet<AccountCreditNoteDetail>();
        }

        public int AccountCreditNoteId { get; set; }

        public int? InvoiceNum { get; set; }

        [Required]
        [StringLength(50)]
        public string CustomerAC { get; set; }

        [Required]
        [StringLength(255)]
        public string CreditNoteAddress { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime CreditNoteDate { get; set; }

        public float Discount { get; set; }

        [Column(TypeName = "money")]
        public decimal PostPacking { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalValue { get; set; }

        [Column(TypeName = "money")]
        public decimal VATValue { get; set; }

        public bool CreditNoteYesNo { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalVAT { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalPaid { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DatePaid { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DatePosted { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(20)]
        public string SearchCreditNoteId { get; set; }

        [StringLength(255)]
        public string JobAddress { get; set; }

        [StringLength(50)]
        public string OrderNumber { get; set; }

        [Column(TypeName = "money")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal Balance { get; set; }

        public bool IsPosted { get; set; }

        public bool IsClosed { get; set; }

        public int? statementId { get; set; }

        public string EmailAddress { get; set; }

        [StringLength(20)]
        public string DateCreditNoteNum { get; set; }

        public virtual AccountCustomer AccountCustomer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountCreditNoteDetail> AccountCreditNoteDetails { get; set; }
    }
}
