using ShopManager.helper;

namespace ShopManager.DTO
{
    public class CashCustomerDto : ValidatableBindableBase
    {
        private string _CustomerAc;
        private string _CompanyName;
        private string _ContactName;
        private string _Address1;
        private string _address2;
        private string _address3;
        private string _Address4;
        private string _address5;
        private string _PostCode;
        private string _Phone;
        private string _Fax;
        private string _Email;
        private string _WebPage;
        private string _NotePad;
        private float? _CustomersDiscount;
        private bool? _Discontinued;
        public string CustomerAc
        {
            get
            {
                return _CustomerAc;
            }
            set
            {
                SetProperty(ref _CustomerAc, value);
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
        public string Address1
        {
            get
            {
                return _Address1;
            }
            set
            {
                SetProperty(ref _Address1, value);
            }
        }
        public string address2
        {
            get
            {
                return _address2;
            }
            set
            {
                SetProperty(ref _address2, value);
            }
        }
        public string address3
        {
            get
            {
                return _address3;
            }
            set
            {
                SetProperty(ref _address3, value);
            }
        }
        public string Address4
        {
            get
            {
                return _Address4;
            }
            set
            {
                SetProperty(ref _Address4, value);
            }
        }
        public string address5
        {
            get
            {
                return _address5;
            }
            set
            {
                SetProperty(ref _address5, value);
            }
        }
        public string PostCode
        {
            get
            {
                return _PostCode;
            }
            set
            {
                SetProperty(ref _PostCode, value);
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
        public string WebPage
        {
            get
            {
                return _WebPage;
            }
            set
            {
                SetProperty(ref _WebPage, value);
            }
        }
        public string NotePad
        {
            get
            {
                return _NotePad;
            }
            set
            {
                SetProperty(ref _NotePad, value);
            }
        }
        public float? CustomersDiscount
        {
            get
            {
                return _CustomersDiscount;
            }
            set
            {
                SetProperty(ref _CustomersDiscount, value);
            }
        }
        public bool? Discontinued
        {
            get
            {
                return _Discontinued;
            }
            set
            {
                SetProperty(ref _Discontinued, value);
            }
        }
    }

}
