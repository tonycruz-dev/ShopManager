using AutoMapper;
using ShopManager.DTO;
using ShopManager.helper;
using ShopManager.Models;
using ShopManager.UI.Products.Repository;
using System;
using System.Collections.Generic;
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
            //CopyCustomer(cust, AccountCustomer);
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
                var mapAccountCustomer = _mapper.Map(Product, productNew);
                await _repo.AddProductAsync(mapAccountCustomer);
            }
            Done();

        }
        private bool CanSave()
        {
            return !Product.HasErrors;
        }
        //private void UpdateCustomer(AccountCustomerDto source)
        //{
        //    _customerToSave = new AccountCustomer();
        //    var target = _customerToSave;
        //    target.CustomerAc = source.CustomerAc;
        //    target.CompanyName = source.CompanyName;
        //    target.ContactName = source.ContactName;
        //    target.Address1 = source.Address1;
        //    target.address2 = source.Address2;
        //    target.address3 = source.address3;
        //    target.Address4 = source.Address4;
        //    target.address5 = source.address5;
        //    target.PostCode = source.PostCode;
        //    target.Phone = source.Phone;
        //    target.Fax = source.Fax;
        //    target.Email = source.Email;
        //    target.WebPage = source.WebPage;
        //    target.NotePad = source.NotePad;
        //}
    }
}
