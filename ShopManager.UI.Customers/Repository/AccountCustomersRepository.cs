using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopManager.Data;
using ShopManager.Models;

namespace ShopManager.UI.Customers.Repository
{
    public class AccountCustomersRepository : IAccountCustomersRepository
    {
        ModelShopManager _context = new ModelShopManager();
        public async Task<List<AccountCustomer>> GetCustomersAsync()
        {
            return await _context.AccountCustomers.ToListAsync();
        }
        public async Task<AccountCustomer> GetCustomerAsync(string AccountNum)
        {
            return await _context.AccountCustomers.FirstOrDefaultAsync(c => c.CustomerAc == AccountNum);
        }

        public async Task<AccountCustomer> AddCustomerAsync(AccountCustomer customer)
        {
            _context.AccountCustomers.Add(customer);
            await _context.SaveChangesAsync();
            return customer;
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

        public async Task DeleteCustomerAsync(string customerId)
        {
            var customer = _context.AccountCustomers.FirstOrDefault(c => c.CustomerAc == customerId);
            if (customer != null)
            {
                _context.AccountCustomers.Remove(customer);
            }
            await _context.SaveChangesAsync();
        }
    }
}
