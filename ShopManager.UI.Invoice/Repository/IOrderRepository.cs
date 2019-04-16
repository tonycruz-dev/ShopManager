using ShopManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.UI.Invoice.Repository
{
   public interface IOrderRepository
    {
        Task<List<Product>> GetProductsAsync();
        Task<Product> UpdateProductAsync(Product product);

        Task<List<AccountCustomer>> GetAccountCustomersAsync();
        Task<AccountCustomer> GetAccountCustomerAsync(string AccountNum);

        Task<List<CashCustomer>> GetCashCustomersAsync();
        Task<CashCustomer> GetCashCustomerAsync(string AccountNum);

        Task<AccountInvoice> AddAccountInvoiceAsync(AccountInvoice invoice);
        Task<AccountInvoiceDetail> AddAccountInvoiceDetailAsync(AccountInvoiceDetail invoiceDetails);

        Task<CashInvoice> AddCashInvoiceAsync(CashInvoice invoice);
        Task<CashInvoiceDetail> AddCashInvoiceDetailAsync(CashInvoiceDetail invoiceDetails);

        Task<Estimate> AddEstimateAsync(Estimate estimate);
        Task<EstimateDetail> AddEstimateDetailAsync(EstimateDetail estimateDetails);
    }
}
