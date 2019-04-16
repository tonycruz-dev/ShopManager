using ShopManager.CustomersControl;
using ShopManager.DTO;
using ShopManager.helper;
using ShopManager.ProductControl;
using ShopManager.Repository;
using Microsoft.Practices.Unity;

namespace ShopManager.UI
{
    public class MainWindowsViewModel: BindableBase
    {
        private CustomerViewModel _customerListViewModel;
        private ProductViewModel _productViewModel = new ProductViewModel();
        private EditCustomerViewModel _addEditViewModel;
        private BindableBase _CurrentViewModel;
        //private ICustomersRepository _repo =  new CustomersRepository() ;
        public MainWindowsViewModel()
        {
            NavCommand = new RelayCommand<string>(OnNav);
            _customerListViewModel = ContainerHelper.Container.Resolve<CustomerViewModel>();
            _addEditViewModel = ContainerHelper.Container.Resolve<EditCustomerViewModel>();
            //_customerListViewModel = new CustomerViewModel(_repo);
            //_addEditViewModel = new EditCustomerViewModel(_repo);
          
            //_customerListViewModel.PlaceOrderRequested += NavToOrder;
            _customerListViewModel.AddCustomerRequested += NavToAddCustomer;
            _customerListViewModel.EditCustomerRequested += NavToEditCustomer;
            _addEditViewModel.Done += NavToCustomerList;
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
                case "products":
                    CurrentViewModel = _productViewModel;
                    break;
                case "customers":
                default:
                    CurrentViewModel = _customerListViewModel;
                    break;
            }
        }
        private void NavToAddCustomer(AccountCustomerDto cust)
        {
            _addEditViewModel.EditMode = false;
            _addEditViewModel.SetAccountCustomer(cust);
            CurrentViewModel = _addEditViewModel;
        }

        private void NavToEditCustomer(AccountCustomerDto cust)
        {
            _addEditViewModel.EditMode = true;
            _addEditViewModel.SetAccountCustomer(cust);
            CurrentViewModel = _addEditViewModel;
        }
        public void NavToCustomerList()
        {
            CurrentViewModel = _customerListViewModel;
        }
    }
}
