using ShopManager.DTO;
using ShopManager.helper;
using ShopManager.UI.Customers.Views;

using Unity;

namespace ShopManager.UI.Customers
{
   public class MainWindowViewModel: BindableBase
    {
        private AccountCustomerListViewModel _accountCustomerListViewModel;
        private EditAccountCustomerViewModel _editAccountCustomerViewModel;
        private BindableBase _CurrentViewModel;

        public MainWindowViewModel()
        {
            NavCommand = new RelayCommand<string>(OnNav);
            _accountCustomerListViewModel = ContainerHelper.Container.Resolve<AccountCustomerListViewModel>();
            _editAccountCustomerViewModel = ContainerHelper.Container.Resolve<EditAccountCustomerViewModel>();

            _accountCustomerListViewModel.AddCustomerRequested += NavToAddCustomer;
            _accountCustomerListViewModel.EditCustomerRequested += NavToEditCustomer;
            _editAccountCustomerViewModel.Done += NavToCustomerList;
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
                    CurrentViewModel = null;
                    break;
                case "customers":
                default:
                    CurrentViewModel = _accountCustomerListViewModel;
                    break;
            }
        }
        private void NavToAddCustomer(AccountCustomerDto cust)
        {
            _editAccountCustomerViewModel.EditMode = false;
            _editAccountCustomerViewModel.SetAccountCustomer(cust);
            CurrentViewModel = _editAccountCustomerViewModel;
        }
        private void NavToEditCustomer(AccountCustomerDto cust)
        {
            _editAccountCustomerViewModel.EditMode = true;
            _editAccountCustomerViewModel.SetAccountCustomer(cust);
            CurrentViewModel = _editAccountCustomerViewModel;
        }
        public void NavToCustomerList()
        {
            CurrentViewModel = _accountCustomerListViewModel;
        }
    }
}
