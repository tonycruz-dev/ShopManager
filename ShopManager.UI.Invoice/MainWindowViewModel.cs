using ShopManager.DTO;
using ShopManager.helper;
using ShopManager.UI.Invoice.Views;
using Unity;


namespace ShopManager.UI.Invoice
{
    public class MainWindowViewModel: BindableBase
    {
        private OrderViewModel _orderViewModel;
        private AccountInvoiceViewModel _accountInvoiceViewModel;
        private BindableBase _CurrentViewModel;
        public MainWindowViewModel()
        {
            NavCommand = new RelayCommand<string>(OnNav);
            _orderViewModel = ContainerHelper.Container.Resolve<OrderViewModel>();
            _accountInvoiceViewModel = ContainerHelper.Container.Resolve<AccountInvoiceViewModel>();

            // _productListViewModel.AddProductRequest += NavToAddProduct;
            //  _productListViewModel.EditProductRequest += NavToEditProduct;
              _orderViewModel.Done += NavToAccountInvoice;

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
                case "AccountInvoice":
                    CurrentViewModel = _accountInvoiceViewModel;
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
        public void NavToAccountInvoice()
        {
            CurrentViewModel = _accountInvoiceViewModel;
        }
        public void NavToOrder()
        {
            CurrentViewModel = _orderViewModel;
        }
    }
}
