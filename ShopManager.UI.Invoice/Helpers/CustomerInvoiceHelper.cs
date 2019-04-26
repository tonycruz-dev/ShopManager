using ShopManager.DTO;
using ShopManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.UI.Invoice.Helpers
{
    public static class CustomerInvoiceHelper
    {
        public static AccountInvoice AccountCustomerToInvoice(AccountCustomer AcCustomer, OrderDto order)
        {
            var _AccountInvoice = new AccountInvoice();

            _AccountInvoice.InvoiceAddress = AcCustomer.CompanyName + Environment.NewLine + AcCustomer.Address1 + Environment.NewLine + AcCustomer.address2 + Environment.NewLine + AcCustomer.address3 + Environment.NewLine + AcCustomer.Address4 + Environment.NewLine + AcCustomer.address5;
            _AccountInvoice.EmailAddress = AcCustomer.Email;
            _AccountInvoice.CustomerAC = AcCustomer.CustomerAc;
            _AccountInvoice.JobAddress = order.JobAddress;
            _AccountInvoice.TotalPaid = order.TotalPaid;
            _AccountInvoice.TotalVAT = order.TotalVAT;
            _AccountInvoice.TotalValue = order.TotalValue;
            _AccountInvoice.InvoiceDate = DateTime.Now;
            _AccountInvoice.OrderNumber = order.OrderNumber;
            return _AccountInvoice;
        }
        public static AccountInvoiceDetail AccountCustomerToInvoiceDetails(int InvoiceId, OrderItemDto oderItem)
        {

                var details = new AccountInvoiceDetail();
                details.ProductID = oderItem.ProductID;
                details.Description = oderItem.Description;
                details.QTYOrder = oderItem.QTYOrder;
                details.Quantity = oderItem.Quantity;
                details.InvoiceID = InvoiceId;
                details.DateSold = DateTime.Now;
                details.UnitPrice = oderItem.UnitPrice;
                details.Discount = oderItem.Discount;
                details.TotalPrice = oderItem.TotalPrice;
                return details;
        }
    }
}
