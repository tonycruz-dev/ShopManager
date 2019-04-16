using ShopManager.DTO;
using ShopManager.helper;
using ShopManager.UI.Invoice.Views;
using Unity;


namespace ShopManager.UI.Invoice
{
    public class MainWindowViewModel: BindableBase
    {
        private OrderViewModel _orderViewModel;
        private BindableBase _CurrentViewModel;
        public MainWindowViewModel()
        {
            NavCommand = new RelayCommand<string>(OnNav);
            _orderViewModel = ContainerHelper.Container.Resolve<OrderViewModel>();
           // _addEditProductViewModel = ContainerHelper.Container.Resolve<AddEditProductViewModel>();

           // _productListViewModel.AddProductRequest += NavToAddProduct;
          //  _productListViewModel.EditProductRequest += NavToEditProduct;
          //  _addEditProductViewModel.Done += NavToProductList;

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
                case "Orders":
                default:
                    CurrentViewModel = _orderViewModel;
                    break;
            }
        }
        private void NavToAddProduct(ProductDto product)
        {
            //_addEditProductViewModel.EditMode = false;
            //_addEditProductViewModel.SetProduct(product);
           // CurrentViewModel = _addEditProductViewModel;
        }
        private void NavToEditProduct(ProductDto product)
        {
            //_addEditProductViewModel.EditMode = true;
            //_addEditProductViewModel.SetProduct(product);
            //CurrentViewModel = _addEditProductViewModel;
        }
        public void NavToOrder()
        {
            CurrentViewModel = _orderViewModel;
        }
    }
}
