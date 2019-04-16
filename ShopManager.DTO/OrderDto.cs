using ShopManager.helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.DTO
{
    public class OrderDto:ValidatableBindableBase
    {
        private int _Id;
        private int? _RefNum;
        private string _AccountAC;
        private string _Address;
        private DateTime? _OrderDate;
        private float? _Discount;
        private decimal? _PostPacking;
        private decimal? _TotalValue;
        private decimal? _VATValue;
        private bool _InvoiceYesNo;
        private decimal? _TotalVAT;
        private decimal? _TotalPaid;
        private DateTime? _DatePaid;
        private DateTime? _DatePosted;
        private string _JobAddress;
        private string _OrderNumber;
        private decimal _Balance;
        private string _EmailAddress;
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
        public int? RefNum
        {
            get
            {
                return _RefNum;
            }
            set
            {
                SetProperty(ref _RefNum, value);
            }
        }
        public string AccountAC
        {
            get
            {
                return _AccountAC;
            }
            set
            {
                SetProperty(ref _AccountAC, value);
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
        public DateTime? OrderDate
        {
            get
            {
                return _OrderDate;
            }
            set
            {
                SetProperty(ref _OrderDate, value);
            }
        }
        public float? Discount
        {
            get
            {
                return _Discount;
            }
            set
            {
                SetProperty(ref _Discount, value);
            }
        }
        public decimal? PostPacking
        {
            get
            {
                return _PostPacking;
            }
            set
            {
                SetProperty(ref _PostPacking, value);
            }
        }
        public decimal? TotalValue
        {
            get
            {
                return _TotalValue;
            }
            set
            {
                SetProperty(ref _TotalValue, value);
            }
        }
        public decimal? VATValue
        {
            get
            {
                return _VATValue;
            }
            set
            {
                SetProperty(ref _VATValue, value);
            }
        }
        public bool InvoiceYesNo
        {
            get
            {
                return _InvoiceYesNo;
            }
            set
            {
                SetProperty(ref _InvoiceYesNo, value);
            }
        }
        public decimal? TotalVAT
        {
            get
            {
                return _TotalVAT;
            }
            set
            {
                SetProperty(ref _TotalVAT, value);
            }
        }
        public decimal? TotalPaid
        {
            get
            {
                return _TotalPaid;
            }
            set
            {
                SetProperty(ref _TotalPaid, value);
            }
        }
        public DateTime? DatePaid
        {
            get
            {
                return _DatePaid;
            }
            set
            {
                SetProperty(ref _DatePaid, value);
            }
        }
        public DateTime? DatePosted
        {
            get
            {
                return _DatePosted;
            }
            set
            {
                SetProperty(ref _DatePosted, value);
            }
        }
        
        public string JobAddress
        {
            get
            {
                return _JobAddress;
            }
            set
            {
                SetProperty(ref _JobAddress, value);
            }
        }
        public string OrderNumber
        {
            get
            {
                return _OrderNumber;
            }
            set
            {
                SetProperty(ref _OrderNumber, value);
            }
        }
        public decimal Balance
        {
            get
            {
                return _Balance;
            }
            set
            {
                SetProperty(ref _Balance, value);
            }
        }
        
     
      
        public string EmailAddress
        {
            get
            {
                return _EmailAddress;
            }
            set
            {
                SetProperty(ref _EmailAddress, value);
            }
        }
       
    }
}
