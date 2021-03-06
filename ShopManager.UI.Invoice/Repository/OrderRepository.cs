﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopManager.Data;
using ShopManager.Models;
using ShopManager.UI.Invoice.ViewModel;

namespace ShopManager.UI.Invoice.Repository
{
    public class OrderRepository : IOrderRepository
    {
        ModelShopManager _context = new ModelShopManager();

        // Manage products
        public async Task<List<Product>> GetProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> UpdateProductAsync(Product product)
        {
            if (!_context.Products.Local.Any(p => p.ProductID == product.ProductID))
            {
                _context.Products.Attach(product);
            }
            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return product;
        }

        // Manage Account Invoices
        public async Task<AccountInvoice> AddAccountInvoiceAsync(AccountInvoice invoice)
        {
            _context.AccountInvoices.Add(invoice);
            await _context.SaveChangesAsync();
            return invoice;
        }

        public async Task<AccountInvoiceDetail> AddAccountInvoiceDetailAsync(AccountInvoiceDetail invoiceDetails)
        {
            _context.AccountInvoiceDetails.Add(invoiceDetails);
            await _context.SaveChangesAsync();
            return invoiceDetails;
        }

        // Manage Cash Invoices
        public async Task<CashInvoice> AddCashInvoiceAsync(CashInvoice invoice)
        {
            _context.CashInvoices.Add(invoice);
            await _context.SaveChangesAsync();
            return invoice;
        }

        public async Task<CashInvoiceDetail> AddCashInvoiceDetailAsync(CashInvoiceDetail invoiceDetails)
        {
            _context.CashInvoiceDetails.Add(invoiceDetails);
            await _context.SaveChangesAsync();
            return invoiceDetails;
        }

        // Manage Estimate Invoices
        public async Task<EstimateDetail> AddEstimateDetailAsync(EstimateDetail estimateDetails)
        {
            _context.EstimateDetails.Add(estimateDetails);
            await _context.SaveChangesAsync();
            return estimateDetails;
        }

        public async Task<Estimate> AddEstimateAsync(Estimate estimate)
        {
            _context.Estimates.Add(estimate);
            await _context.SaveChangesAsync();
            return estimate;
        }

        // Manage Account Customer

        public async Task<AccountCustomer> GetAccountCustomerAsync(string AccountNum)
        {
            return await _context.AccountCustomers.FirstOrDefaultAsync(c => c.CustomerAc == AccountNum);
        }
        public async Task<List<AccountCustomer>> GetAccountCustomersAsync()
        {
            return await _context.AccountCustomers.ToListAsync();
        }
        // Manage Cash Customer
        public async Task<CashCustomer> GetCashCustomerAsync(string AccountNum)
        {
            return await _context.CashCustomers.FirstOrDefaultAsync(c => c.CustomerAc == AccountNum);
        }

        public async Task<List<CashCustomer>> GetCashCustomersAsync()
        {
            return await _context.CashCustomers.ToListAsync();
        }

        public async Task<List<SelectAccountToInsert>> GetAccountCustomersSelectAsync()
        {
            var ResultAccountCustomers = await(from Acc in _context.AccountCustomers
                                               orderby Acc.CustomerAc
                                               select new SelectAccountToInsert
                                               {
                                                   Account = Acc.CustomerAc,
                                                   Company = Acc.CompanyName,
                                               }).ToListAsync();
            return ResultAccountCustomers;
        }

        public async Task<List<AccountInvoice>> GetAccountInvoicesAsync()
        {
            return await _context.AccountInvoices.Include(ac => ac.AccountInvoiceDetails).OrderByDescending(aob => aob.InvoiceId).ToListAsync();
        }

        public async Task<List<CashInvoice>> GetCashInvoiceAsync()
        {
            return await _context.CashInvoices.Include(ci => ci.CashInvoiceDetails).OrderByDescending(aob => aob.InvoiceID).ToListAsync();
        }

        public async Task<List<Estimate>> GetEstimateAsync()
        {
            return await _context.Estimates.Include(es => es.EstimateDetails).OrderByDescending(eso => eso.EstimateId).ToListAsync();
        }

        public async Task<List<SelectAccountToInsert>> GetCashCustomersSelectAsync()
        {
            var ResultAccountCustomers = await(from Acc in _context.CashCustomers
                                               orderby Acc.CustomerAc
                                               select new SelectAccountToInsert
                                               {
                                                   Account = Acc.CustomerAc,
                                                   Company = Acc.CompanyName,
                                               }).ToListAsync();
            return ResultAccountCustomers;
        }

        public Task<List<SupplierAccount>> GetSupplierAccountAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<SupplierOrder> AddSupplierOrderAsync(SupplierOrder supplierOrder)
        {
            _context.SupplierOrders.Add(supplierOrder);
            await _context.SaveChangesAsync();
            return supplierOrder;
        }

        public async Task<SupplierOrderDetail> AddSupplierOrderDetailAsync(SupplierOrderDetail supplierOrderDetail)
        {
            _context.SupplierOrderDetails.Add(supplierOrderDetail);
            await _context.SaveChangesAsync();
            return supplierOrderDetail;
        }

        public async Task<List<SelectAccountToInsert>> GetSuppliersSelectAsync()
        {
            var ResultSuppliers = await(from Acc in _context.SupplierAccounts
                                               orderby Acc.SupplierAc
                                               select new SelectAccountToInsert
                                               {
                                                   Account = Acc.SupplierAc,
                                                   Company = Acc.CompanyName,
                                               }).ToListAsync();
            return ResultSuppliers;
        }
    }
}
