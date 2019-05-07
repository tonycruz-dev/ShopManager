using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.UI.Invoice.ViewModel
{
   public class ReportsOrderModel
    {
        public int Id { get; set; }
        public string CustomerAC { get; set; }
        public string OrderAddress { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal TotalValue { get; set; }
        public decimal VATValue { get; set; }
        public decimal TotalVAT { get; set; }
        public string JobAddress { get; set; }
        public string OrderNumber { get; set; }
        // Invoice Details
        public int Quantity { get; set; }
        public string ProductID { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public int QTYOrder {get;  set;}
        public double Discount { get; set; }
        public decimal SubTotal { get; set; }
    }
}
