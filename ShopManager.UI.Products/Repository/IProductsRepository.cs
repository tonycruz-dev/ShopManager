using ShopManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.UI.Products.Repository
{
    public interface IProductsRepository
    {
        Task<List<Product>> GetProductsAsync();
        Task<Product> GeProductAsync(int Id);
        Task<Product> AddProductAsync(Product product);
        Task<Product> UpdateProductAsync(Product product);
        Task DeleteProductAsync(int Id);
    }
}
