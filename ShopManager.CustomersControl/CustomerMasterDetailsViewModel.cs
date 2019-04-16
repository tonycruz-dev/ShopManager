using AutoMapper;
using ShopManager.DTO;
using ShopManager.helper;
using ShopManager.Models;
using ShopManager.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.CustomersControl
{
   public class CustomerMasterDetailsViewModel:BindableBase
    {
        private ICustomersRepository _repo;
        private List<AccountCustomerDto> _allCustomers;
        private readonly IMapper _mapper;
        public CustomerMasterDetailsViewModel(ICustomersRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo; 
            AddCustomerCommand = new RelayCommand(OnAddCustomer);
            EditCustomerCommand = new RelayCommand<AccountCustomerDto>(OnEditCustomer);
            ClearSearchCommand = new RelayCommand(OnClearSearch);
            CancelCommand = new RelayCommand(OnCancel);
            SaveCommand = new RelayCommand(OnSave);


        }
        private ObservableCollection<AccountCustomerDto> _customers;
        public ObservableCollection<AccountCustomerDto> Customers
        {
            get { return _customers; }
            set { SetProperty(ref _customers, value); }
        }

        public async void LoadCustomers()
        {

            //var localCustomers = await _repo.GetCustomersAsync();
            _allCustomers = _mapper.Map<List<AccountCustomerDto>>(await _repo.GetCustomersAsync());
            Customers = new ObservableCollection<AccountCustomerDto>(_allCustomers);
            Customer = _allCustomers[0];
            

        }
        private bool _EditMode;
        public bool EditMode
        {
            get { return _EditMode; }
            set { SetProperty(ref _EditMode, value); }
        }
        private AccountCustomerDto _Customer;
        public AccountCustomerDto Customer
        {
            get { return _Customer; }
            set
            {
                //SetAccountCustomer(_Customer);
                SetProperty(ref _Customer, value);
            }
        }
        public RelayCommand CancelCommand { get; private set; }
        public RelayCommand SaveCommand { get; private set; }
        private AccountCustomer _customerToSave = null;

        private string _SearchInput;
        public string SearchInput
        {
            get { return _SearchInput; }
            set
            {
                SetProperty(ref _SearchInput, value);
                FilterCustomers(_SearchInput);
            }
        }
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

        public RelayCommand<AccountCustomerDto> PlaceOrderCommand { get; private set; }
        public RelayCommand AddCustomerCommand { get; private set; }
        public RelayCommand<AccountCustomerDto> EditCustomerCommand { get; private set; }
        public RelayCommand ClearSearchCommand { get; private set; }

        public event Action<String> PlaceOrderRequested = delegate { };
        public event Action<AccountCustomerDto> AddCustomerRequested = delegate { };
        public event Action<AccountCustomerDto> EditCustomerRequested = delegate { };
        public event Action Done = delegate { };

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
        private void OnCancel()
        {
            Done();
        }

        private async void OnSave()
        {
            //UpdateCustomer(Customer);
            //if (EditMode)
            var _customerToUpdate = await _repo.GetCustomerAsync(Customer.CustomerAc);
            _mapper.Map(Customer, _customerToUpdate);
            await _repo.UpdateCustomerAsync(_customerToUpdate);
            //else
            //    await _repo.AddCustomerAsync(_customerToSave);
            //Done();
        }
        private bool CanSave()
        {
            return !Customer.HasErrors;
            //if (Customer != null)
            //{
            // return !Customer.HasErrors;
            //}
            //return false;
        }
        public void SetAccountCustomer(AccountCustomerDto cust)
        {
  
            if (Customer != null) Customer.ErrorsChanged -= RaiseCanExecuteChanged;
            //Customer = new AccountCustomerDto();
            Customer.ErrorsChanged += RaiseCanExecuteChanged;
           
        }
        private void RaiseCanExecuteChanged(object sender, EventArgs e)
        {
            SaveCommand.RaiseCanExecuteChanged();
        }
        private async void UpdateCustomer(AccountCustomerDto source)
        {
            var _customerToUpdate = await _repo.GetCustomerAsync(source.CustomerAc);


            _mapper.Map(source, _customerToUpdate);
            _customerToSave = _customerToUpdate;

            //_customerToSave = new AccountCustomer();
            //var target = _customerToSave;
            //target.CustomerAc = source.CustomerAc;
            //target.CompanyName = source.CompanyName;
            //target.ContactName = source.ContactName;
            //target.Address1 = source.Address1;
            //target.address2 = source.Address2;
            //target.address3 = source.address3;
            //target.Address4 = source.Address4;
            //target.address5 = source.address5;
            //target.PostCode = source.PostCode;
            //target.Phone = source.Phone;
            //target.Fax = source.Fax;
            //target.Email = source.Email;
            //target.WebPage = source.WebPage;
            //target.NotePad = source.NotePad;
        }
    }
}
