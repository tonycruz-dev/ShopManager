namespace ShopManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("Estimate")]
    public partial class Estimate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Estimate()
        {
            EstimateDetails = new HashSet<EstimateDetail>();
        }

        public int EstimateId { get; set; }

        public int? InvoiceNum { get; set; }

        [StringLength(50)]
        public string CustomerAC { get; set; }

        [StringLength(255)]
        public string EstimateAddress { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EstimateDate { get; set; }

        public float? Discount { get; set; }

        [Column(TypeName = "money")]
        public decimal? PostPacking { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalValue { get; set; }

        [Column(TypeName = "money")]
        public decimal? VATValue { get; set; }

        public bool EstimateYesNo { get; set; }

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
        public string SearchEstimateId { get; set; }

        [StringLength(255)]
        public string JobAddress { get; set; }

        [StringLength(50)]
        public string OrderNumber { get; set; }

        [Column(TypeName = "money")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal Balance { get; set; }

        public bool? IsPosted { get; set; }

        public bool? IsClosed { get; set; }

        public int? statementId { get; set; }

        public string EmailAddress { get; set; }

        [StringLength(20)]
        public string DateEstimateNum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EstimateDetail> EstimateDetails { get; set; }
    }
}
