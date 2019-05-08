using AutoMapper;
using ShopManager.DTO;
using ShopManager.helper;
using ShopManager.Models;
using ShopManager.UI.Products.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.UI.Products.Views
{
   public class AddEditProductViewModel: BindableBase
    {
        private bool _EditMode;
        private readonly IProductsRepository _repo;
        private readonly IMapper _mapper;
        private ObservableCollection<ProductCategoryDto> _productCategories;
        public AddEditProductViewModel(IProductsRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
            CancelCommand = new RelayCommand(OnCancel);
            SaveCommand = new RelayCommand(OnSave, CanSave);
        }
        public bool EditMode
        {
            get { return _EditMode; }
            set { SetProperty(ref _EditMode, value); }
        }

        private ProductDto _Product;

        public ProductDto Product
        {
            get { return _Product; }
            set { SetProperty(ref _Product, value); }
        }
        public ObservableCollection<ProductCategoryDto> ProductCategories
        {
            get { return _productCategories; }
            set { SetProperty(ref _productCategories, value); }
        }
        public RelayCommand CancelCommand { get; private set; }
        public RelayCommand SaveCommand { get; private set; }

        public event Action Done = delegate { };

        private ProductDto _editProduct = null;

        public void SetProduct(ProductDto product)
        {
            _editProduct = product;
            if (Product != null) Product.ErrorsChanged -= RaiseCanExecuteChanged;
            Product = product;
            Product.ErrorsChanged += RaiseCanExecuteChanged;
           
        }
        public void SetCategories(ObservableCollection<ProductCategoryDto> Categories)
        {
            ProductCategories = Categories;
        }
        private void RaiseCanExecuteChanged(object sender, EventArgs e)
        {
            SaveCommand.RaiseCanExecuteChanged();
        }
        
        private void OnCancel()
        {
            Done();
        }

        private async void OnSave()
        {
            // UpdateCustomer(AccountCustomer);

            if (EditMode)
            {
                var productToUpdate = await _repo.GeProductAsync(Product.ProductID);
                var mapProduct = _mapper.Map(Product, productToUpdate);
                await _repo.UpdateProductAsync(mapProduct);
            }

            else
            {
                var productNew = new Product();
                var mapNewProduct = _mapper.Map(Product, productNew);
                if (mapNewProduct.BarCode == null || mapNewProduct.BarCode =="")
                {
                    mapNewProduct.BarCode = Product.ProductCode;
                }
                await _repo.AddProductAsync(mapNewProduct);
            }
            Done();

        }
        private bool CanSave()
        {
            return !Product.HasErrors;
        }
        
    }
}
