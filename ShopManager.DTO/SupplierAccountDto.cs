using ShopManager.helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.DTO
{
    public class SupplierAccountDto : ValidatableBindableBase
    {
        private int _Id;
        private string _SupplierAc;
        private string _CompanyName;
        private string _ContactName;
        private string _Address;
        private string _City;
        private string _Region;
        private string _PostalCode;
        private string _Country;
        private string _Phone;
        private string _Fax;
        private string _Email;
        private string _website;
        private string _Note;
        private string _Name_ID;
        public int Id
        {
            get
            {
                return _Id;
            }
            set
            {
                SetProperty(ref _Id, value);
            }
        }
        public string SupplierAc
        {
            get
            {
                return _SupplierAc;
            }
            set
            {
                SetProperty(ref _SupplierAc, value);
            }
        }
        public string CompanyName
        {
            get
            {
                return _CompanyName;
            }
            set
            {
                SetProperty(ref _CompanyName, value);
            }
        }
        public string ContactName
        {
            get
            {
                return _ContactName;
            }
            set
            {
                SetProperty(ref _ContactName, value);
            }
        }
        public string Address
        {
            get
            {
                return _Address;
            }
            set
            {
                SetProperty(ref _Address, value);
            }
        }
        public string City
        {
            get
            {
                return _City;
            }
            set
            {
                SetProperty(ref _City, value);
            }
        }
        public string Region
        {
            get
            {
                return _Region;
            }
            set
            {
                SetProperty(ref _Region, value);
            }
        }
        public string PostalCode
        {
            get
            {
                return _PostalCode;
            }
            set
            {
                SetProperty(ref _PostalCode, value);
            }
        }
        public string Country
        {
            get
            {
                return _Country;
            }
            set
            {
                SetProperty(ref _Country, value);
            }
        }
        public string Phone
        {
            get
            {
                return _Phone;
            }
            set
            {
                SetProperty(ref _Phone, value);
            }
        }
        public string Fax
        {
            get
            {
                return _Fax;
            }
            set
            {
                SetProperty(ref _Fax, value);
            }
        }
        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                SetProperty(ref _Email, value);
            }
        }
        public string website
        {
            get
            {
                return _website;
            }
            set
            {
                SetProperty(ref _website, value);
            }
        }
        public string Note
        {
            get
            {
                return _Note;
            }
            set
            {
                SetProperty(ref _Note, value);
            }
        }
        public string Name_ID
        {
            get
            {
                return _Name_ID;
            }
            set
            {
                SetProperty(ref _Name_ID, value);
            }
        }
    }
}
