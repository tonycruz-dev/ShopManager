using ShopManager.helper;
using ShopManager.Models;
using ShopManager.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.ProductControl
{
   public class ProductViewModel: BindableBase
    {
        private IProductsRepository _repo = new ProductsRepository();

        public ProductViewModel()
        {
            AddProductCommand = new RelayCommand(OnAddProduct);
            EditProductCommand = new RelayCommand<Product>(OnEditProduct);
        }
        private ObservableCollection<Product> _products;
        public ObservableCollection<Product> Products
        {
            get { return _products; }
            set { SetProperty(ref _products, value); }
        }

        public async void LoadProducts()
        {
            Products = new ObservableCollection<Product>(
                await _repo.GetProductsAsync());
        }

        public RelayCommand AddProductCommand { get; private set; }
        public RelayCommand<Product> EditProductCommand { get; private set; }

        public event Action<Product> AddProductRequested = delegate { };
        public event Action<Product> EditProductRequested = delegate { };

        private void OnAddProduct()
        {
            AddProductRequested(new Product { ProductID = 2 });
        }
        private void OnEditProduct(Product product)
        {
            EditProductRequested(product);
        }
    }
}
