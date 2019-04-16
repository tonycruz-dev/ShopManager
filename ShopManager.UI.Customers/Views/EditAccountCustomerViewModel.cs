using AutoMapper;
using ShopManager.DTO;
using ShopManager.helper;
using ShopManager.Models;
using ShopManager.UI.Customers.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.UI.Customers.Views
{
   public class EditAccountCustomerViewModel: BindableBase
    {
        private bool _EditMode;
        private IAccountCustomersRepository _repo;
        private IMapper _mapper;
        public EditAccountCustomerViewModel(IAccountCustomersRepository repo, IMapper mapper)
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

        private AccountCustomerDto _Customer;

        public AccountCustomerDto AccountCustomer
        {
            get { return _Customer; }
            set { SetProperty(ref _Customer, value); }
        }
        public RelayCommand CancelCommand { get; private set; }
        public RelayCommand SaveCommand { get; private set; }

        public event Action Done = delegate { };

        private AccountCustomerDto _editCustomer = null;
        private AccountCustomer _customerToSave = null;
        public void SetAccountCustomer(AccountCustomerDto cust)
        {
            _editCustomer = cust;
            if (AccountCustomer != null) AccountCustomer.ErrorsChanged -= RaiseCanExecuteChanged;
            AccountCustomer = new AccountCustomerDto();
            AccountCustomer.ErrorsChanged += RaiseCanExecuteChanged;
            CopyCustomer(cust, AccountCustomer);
        }
        private void RaiseCanExecuteChanged(object sender, EventArgs e)
        {
            SaveCommand.RaiseCanExecuteChanged();
        }
        private void CopyCustomer(AccountCustomerDto source, AccountCustomerDto target)
        {
            target.CustomerAc = source.CustomerAc;
            if (EditMode)
            {
                target.CompanyName = source.CompanyName;
                target.ContactName = source.ContactName;
                target.Address1 = source.Address1;
                target.Address2 = source.Address2;
                target.address3 = source.address3;
                target.Address4 = source.Address4;
                target.address5 = source.address5;
                target.PostCode = source.PostCode;
                target.Phone = source.Phone;
                target.Fax = source.Fax;
                target.Email = source.Email;
                target.WebPage = source.WebPage;
                target.NotePad = source.NotePad;
            }

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
               var accountCustomerToUpdate = await _repo.GetCustomerAsync(AccountCustomer.CustomerAc);
               var mapAccountCustomer = _mapper.Map(AccountCustomer, accountCustomerToUpdate);
               await _repo.UpdateCustomerAsync(mapAccountCustomer);
            }

            else
            {
                var accountCustomerNew = new AccountCustomer();
                var mapAccountCustomer = _mapper.Map(AccountCustomer, accountCustomerNew);
                await _repo.AddCustomerAsync(mapAccountCustomer);
             }
            Done();

        }
        private bool CanSave()
        {
            return !AccountCustomer.HasErrors;
        }
        private void UpdateCustomer(AccountCustomerDto source)
        {
            _customerToSave = new AccountCustomer();
            var target = _customerToSave;
            target.CustomerAc = source.CustomerAc;
            target.CompanyName = source.CompanyName;
            target.ContactName = source.ContactName;
            target.Address1 = source.Address1;
            target.address2 = source.Address2;
            target.address3 = source.address3;
            target.Address4 = source.Address4;
            target.address5 = source.address5;
            target.PostCode = source.PostCode;
            target.Phone = source.Phone;
            target.Fax = source.Fax;
            target.Email = source.Email;
            target.WebPage = source.WebPage;
            target.NotePad = source.NotePad;
        }
    }
}
