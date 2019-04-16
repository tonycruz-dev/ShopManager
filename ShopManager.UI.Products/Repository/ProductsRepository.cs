using ShopManager.Data;
using ShopManager.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.UI.Products.Repository
{
    public class ProductsRepository : IProductsRepository
    {
        ModelShopManager _context = new ModelShopManager();
        public async Task<List<Product>> GetProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }
        public async Task<Product> GeProductAsync(int Id)
        {
            return await _context.Products.FirstOrDefaultAsync(c => c.ProductID == Id);
        }
        public async Task<Product> AddProductAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }
        public async Task<Product> UpdateProductAsync(Product product)
        {
            if (!_context.Products.Local.Any(c => c.ProductID == product.ProductID))
            {
                _context.Products.Attach(product);
            }
            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return product;
        }
        public async Task DeleteProductAsync(int Id)
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductID == Id);
            if (product != null)
            {
                _context.Products.Remove(product);
            }
            await _context.SaveChangesAsync();
        }
    }
}
