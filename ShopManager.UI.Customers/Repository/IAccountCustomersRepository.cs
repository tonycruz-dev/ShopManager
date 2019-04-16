using ShopManager.DTO;
using ShopManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.UI.Customers.Repository
{
    public interface IAccountCustomersRepository
    {
        Task<List<AccountCustomer>> GetCustomersAsync();
        Task<AccountCustomer> GetCustomerAsync(string AccountNum);
        Task<AccountCustomer> AddCustomerAsync(AccountCustomer customer);
        Task<AccountCustomer> UpdateCustomerAsync(AccountCustomer customer);
        Task DeleteCustomerAsync(string customerId);
    }
}
