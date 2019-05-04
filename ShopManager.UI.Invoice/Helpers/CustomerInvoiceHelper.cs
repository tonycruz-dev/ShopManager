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

        public static CashInvoice CashCustomerToInvoice(CashCustomer AcCustomer, OrderDto order)
        {
            var _CashInvoice = new CashInvoice();
            var syaer = order.OrderDate.Value.Year.ToString();
            var smonth = order.OrderDate.Value.Month.ToString();
            var sDay = order.OrderDate.Value.Day.ToString();
            _CashInvoice.InvoiceAddress = AcCustomer.CompanyName + Environment.NewLine + AcCustomer.Address1 + Environment.NewLine + AcCustomer.address2 + Environment.NewLine + AcCustomer.address3 + Environment.NewLine + AcCustomer.Address4 + Environment.NewLine + AcCustomer.address5;
            _CashInvoice.EmailAddress = AcCustomer.Email;
            _CashInvoice.CustomerAC = AcCustomer.CustomerAc;
            _CashInvoice.JobAddress = order.JobAddress;
            _CashInvoice.TotalPaid =0;
            _CashInvoice.VATValue = order.TotalVAT;
            _CashInvoice.TotalVAT = order.TotalPaid;
            _CashInvoice.TotalValue = order.TotalValue;
            _CashInvoice.InvoiceDate = DateTime.Now;
            _CashInvoice.OrderNumber = order.OrderNumber;
            _CashInvoice.Discount = 0;
            _CashInvoice.PostPacking = 0;
            _CashInvoice.IsCard = true;
            _CashInvoice.IsCheque = false;
            _CashInvoice.IsCard = false;
            _CashInvoice.TotalPaid = 0;
            _CashInvoice.DateInvoiceNum = syaer + "-" + smonth + "-" + sDay;
            return _CashInvoice;
        }
        public static CashInvoiceDetail CashCustomerToInvoiceDetails(int InvoiceId, OrderItemDto oderItem)
        {

            var details = new CashInvoiceDetail();
            details.ProductId = oderItem.ProductID;
            details.Description = oderItem.Description;
            details.QTYOrder = oderItem.QTYOrder;
            details.Quantity = oderItem.Quantity;
            details.InvoiceId = InvoiceId;
            details.DateSold = DateTime.Now;
            details.UnitPrice = oderItem.UnitPrice;
            details.Discount = oderItem.Discount;
            details.TotalPrice = oderItem.TotalPrice;
            return details;
        }
        public static Estimate CashCustomerToEstimate(CashCustomer AcCustomer, OrderDto order)
        {
            var _Estimate = new Estimate();

            _Estimate.EstimateAddress = AcCustomer.CompanyName + Environment.NewLine + AcCustomer.Address1 + Environment.NewLine + AcCustomer.address2 + Environment.NewLine + AcCustomer.address3 + Environment.NewLine + AcCustomer.Address4 + Environment.NewLine + AcCustomer.address5;
            _Estimate.EmailAddress = AcCustomer.Email;
            _Estimate.CustomerAC = AcCustomer.CustomerAc;
            _Estimate.JobAddress = order.JobAddress;
            _Estimate.TotalPaid = order.TotalPaid;
            _Estimate.TotalVAT = order.TotalVAT;
            _Estimate.TotalValue = order.TotalValue;
            _Estimate.EstimateDate = DateTime.Now;
            _Estimate.OrderNumber = order.OrderNumber;
            return _Estimate;
        }
        public static EstimateDetail CashCustomerToEstimateDetails(int InvoiceId, OrderItemDto oderItem)
        {

            var details = new EstimateDetail();
            details.ProductId = oderItem.ProductID;
            details.Description = oderItem.Description;
            details.QTYOrder = oderItem.QTYOrder;
            details.Quantity = oderItem.Quantity;
            details.EstimateId= InvoiceId;
            details.DateSold = DateTime.Now;
            details.UnitPrice = oderItem.UnitPrice;
            details.Discount = oderItem.Discount;
            details.TotalPrice = oderItem.TotalPrice;
            return details;
        }
        public static Estimate AccountCustomerToEstimate(AccountCustomer AcCustomer, OrderDto order)
        {
            var _Estimate = new Estimate();

            _Estimate.EstimateAddress = AcCustomer.CompanyName + Environment.NewLine + AcCustomer.Address1 + Environment.NewLine + AcCustomer.address2 + Environment.NewLine + AcCustomer.address3 + Environment.NewLine + AcCustomer.Address4 + Environment.NewLine + AcCustomer.address5;
            _Estimate.EmailAddress = AcCustomer.Email;
            _Estimate.CustomerAC = AcCustomer.CustomerAc;
            _Estimate.JobAddress = order.JobAddress;
            _Estimate.TotalPaid = order.TotalPaid;
            _Estimate.TotalVAT = order.TotalVAT;
            _Estimate.TotalValue = order.TotalValue;
            _Estimate.EstimateDate = DateTime.Now;
            _Estimate.OrderNumber = order.OrderNumber;
            return _Estimate;
        }
        public static EstimateDetail AccountCustomerToEstimateDetails(int InvoiceId, OrderItemDto oderItem)
        {

            var details = new EstimateDetail();
            details.ProductId = oderItem.ProductID;
            details.Description = oderItem.Description;
            details.QTYOrder = oderItem.QTYOrder;
            details.Quantity = oderItem.Quantity;
            details.EstimateId = InvoiceId;
            details.DateSold = DateTime.Now;
            details.UnitPrice = oderItem.UnitPrice;
            details.Discount = oderItem.Discount;
            details.TotalPrice = oderItem.TotalPrice;
            return details;
        }
    }
}
