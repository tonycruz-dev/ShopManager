using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopManager.Data;
using ShopManager.DTO;
using ShopManager.Models;

namespace ShopManager.Repository
{
    public class CustomersRepository : ICustomersRepository
    {
        ModelShopManager _context = new ModelShopManager();
        public async Task<AccountCustomer> AddCustomerAsync(AccountCustomer customer)
        {
            _context.AccountCustomers.Add(customer);
            await _context.SaveChangesAsync();
            return customer;
        }

        public async Task DeleteCustomerAsync(string customerId)
        {
            var customer = _context.AccountCustomers.FirstOrDefault(c => c.CustomerAc == customerId);
            if (customer != null)
            {
                _context.AccountCustomers.Remove(customer);
            }
            await _context.SaveChangesAsync();
        }

        public async Task<AccountCustomer> GetCustomerAsync(string AccountNum)
        {
            return await _context.AccountCustomers.FirstOrDefaultAsync(c => c.CustomerAc == AccountNum);
        }

        public async Task<List<AccountCustomer>> GetCustomersAsync()
        {
            return await _context.AccountCustomers.ToListAsync();
        }

        public async Task<List<AccountCustomerDto>> GetDTOCustomersAsync()
        {
            var ResultAccountCustomers = await (from Acc in _context.AccountCustomers
                                          orderby Acc.CustomerAc
                                          select new AccountCustomerDto
                                          {
                                              CustomerAc = Acc.CustomerAc,
                                              CompanyName = Acc.CompanyName,
                                              ContactName = Acc.ContactName,
                                              Address1 = Acc.Address1,
                                              Address2 = Acc.address2,
                                              address3 = Acc.address3,
                                              Address4 = Acc.Address4,
                                              address5 = Acc.address5,
                                              PostCode = Acc.PostCode,
                                              Phone = Acc.Phone,
                                              Fax = Acc.Fax,
                                              Email = Acc.Email,
                                              WebPage = Acc.WebPage,
                                              NotePad = Acc.NotePad
                                          }).ToListAsync();
             return ResultAccountCustomers;
        }

        public async Task<AccountCustomer> UpdateCustomerAsync(AccountCustomer customer)
        {
            if (!_context.AccountCustomers.Local.Any(c => c.CustomerAc == customer.CustomerAc))
            {
                _context.AccountCustomers.Attach(customer);
            }
            _context.Entry(customer).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return customer; 
        }
    }
}
