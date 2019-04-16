using ShopManager.DTO;
using ShopManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.Repository
{
    public interface ICustomersRepository
    {
        Task<List<AccountCustomer>> GetCustomersAsync();
        Task<List<AccountCustomerDto>> GetDTOCustomersAsync();
        Task<AccountCustomer> GetCustomerAsync(string AccountNum);
        Task<AccountCustomer> AddCustomerAsync(AccountCustomer customer);
        Task<AccountCustomer> UpdateCustomerAsync(AccountCustomer customer);
        Task DeleteCustomerAsync(string customerId);
    }
}
