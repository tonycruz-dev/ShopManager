using ShopManager.DTO;
using ShopManager.helper;
using ShopManager.UI.Products.Views;
using Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.UI.Products
{
    public class MainWindowViewModel: BindableBase
    {
        private ProductListViewModel _productListViewModel;
        private AddEditProductViewModel _addEditProductViewModel;
        private BindableBase _CurrentViewModel; 
        public MainWindowViewModel()
        {
            NavCommand = new RelayCommand<string>(OnNav);
            _productListViewModel = ContainerHelper.Container.Resolve<ProductListViewModel>();
            _addEditProductViewModel = ContainerHelper.Container.Resolve<AddEditProductViewModel>();

            _productListViewModel.AddProductRequest += NavToAddProduct;
            _productListViewModel.EditProductRequest += NavToEditProduct;
            _addEditProductViewModel.Done += NavToProductList;

        }
        public BindableBase CurrentViewModel
        {
            get { return _CurrentViewModel; }
            set { SetProperty(ref _CurrentViewModel, value); }
        }

        public RelayCommand<string> NavCommand { get; private set; }


        private void OnNav(string destination)
        {
            switch (destination)
            {
                case "Customers":
                    CurrentViewModel = null;
                    break;
                case "products":
                default:
                    CurrentViewModel = _productListViewModel;
                    break;
            }
        }
        private void NavToAddProduct(ProductDto product)
        {
            _addEditProductViewModel.EditMode = false;
            _addEditProductViewModel.SetProduct(product);
            CurrentViewModel = _addEditProductViewModel;
        }
        private void NavToEditProduct(ProductDto product)
        {
            _addEditProductViewModel.EditMode = true;
            _addEditProductViewModel.SetCategories(_productListViewModel.ProductCategories);
            _addEditProductViewModel.SetProduct(product);
            CurrentViewModel = _addEditProductViewModel;
        }
        public void NavToProductList()
        {
            CurrentViewModel = _productListViewModel;
        }
    }
}
