namespace ShopManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
  

    public partial class AccountCreditNoteDetail
    {
        public int AccountCreditNoteDetailId { get; set; }

        public int CreditNoteDetailId { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductID { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal SalesPrice { get; set; }

        public int QTYOrder { get; set; }

        public int Quantity { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DateSold { get; set; }

        public float Discount { get; set; }

        [Column(TypeName = "money")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal SubTotal { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int Shortage { get; set; }

        public bool? IsReturn { get; set; }

        public bool? IsShortagePosted { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalPrice { get; set; }

        public virtual AccountCreditNote AccountCreditNote { get; set; }
    }
}
