using AutoMapper;
using ShopManager.DTO;
using ShopManager.helper;
using ShopManager.UI.Customers.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ShopManager.UI.Customers.Views
{
    public class AccountCustomerListViewModel: BindableBase
    {
        private IAccountCustomersRepository _repo;
        private List<AccountCustomerDto> _allCustomers;
        private readonly IMapper _mapper;
        private ObservableCollection<AccountCustomerDto> _customers;
        private string _SearchInput;

        public AccountCustomerListViewModel(IAccountCustomersRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
            PlaceOrderCommand = new RelayCommand<AccountCustomerDto>(OnPlaceOrder);
            AddCustomerCommand = new RelayCommand(OnAddCustomer);
            EditCustomerCommand = new RelayCommand<AccountCustomerDto>(OnEditCustomer);
            ClearSearchCommand = new RelayCommand(OnClearSearch);
        }
        public async void LoadCustomers()
        {
            _allCustomers = _mapper.Map<List<AccountCustomerDto>>(await _repo.GetCustomersAsync());
            Customers = new ObservableCollection<AccountCustomerDto>(_allCustomers);
        }
        public ObservableCollection<AccountCustomerDto> Customers
        {
            get { return _customers; }
            set { SetProperty(ref _customers, value); }
        }

        public string SearchInput
        {
            get { return _SearchInput; }
            set
            {
                SetProperty(ref _SearchInput, value);
                FilterCustomers(_SearchInput);
            }
        }


        public RelayCommand<AccountCustomerDto> PlaceOrderCommand { get; private set; }
        public RelayCommand AddCustomerCommand { get; private set; }
        public RelayCommand<AccountCustomerDto> EditCustomerCommand { get; private set; }
        public RelayCommand ClearSearchCommand { get; private set; }

        public event Action<String> PlaceOrderRequested = delegate { };
        public event Action<AccountCustomerDto> AddCustomerRequested = delegate { };
        public event Action<AccountCustomerDto> EditCustomerRequested = delegate { };

        private void FilterCustomers(string searchInput)
        {
            if (string.IsNullOrWhiteSpace(searchInput))
            {
                Customers = new ObservableCollection<AccountCustomerDto>(_allCustomers);
                return;
            }
            else
            {
                Customers = new ObservableCollection<AccountCustomerDto>(_allCustomers.Where(c => c.CustomerAc.ToLower().Contains(searchInput.ToLower())));
            }
        }

        private void OnPlaceOrder(AccountCustomerDto customer)
        {
            PlaceOrderRequested(customer.CustomerAc);
        }

        private void OnAddCustomer()
        {
            AddCustomerRequested(new AccountCustomerDto { CustomerAc = Guid.NewGuid().ToString() });
        }

        private void OnEditCustomer(AccountCustomerDto cust)
        {
            EditCustomerRequested(cust);
        }

        private void OnClearSearch()
        {
            SearchInput = null;
        }
    }
}
