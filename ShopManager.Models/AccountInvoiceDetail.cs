namespace ShopManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public partial class AccountInvoiceDetail
    {
        public int AccountInvoiceDetailId { get; set; }

        public int? InvoiceID { get; set; }

        public string Description { get; set; }

        [StringLength(50)]
        public string ProductID { get; set; }

        [Column(TypeName = "money")]
        public decimal? UnitPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? SalesPrice { get; set; }

        public int? QTYOrder { get; set; }

        public int? Quantity { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DateSold { get; set; }

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

        public virtual AccountInvoice AccountInvoice { get; set; }
    }
}
