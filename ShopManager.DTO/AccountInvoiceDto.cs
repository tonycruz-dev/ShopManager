using ShopManager.helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.DTO
{
    public class AccountInvoiceDto : ValidatableBindableBase
    {
        private int _InvoiceId;
        private int? _InvoiceNum;
        private string _CustomerAC;
        private string _InvoiceAddress;
        private DateTime? _InvoiceDate;
        private float? _Discount;
        private decimal? _PostPacking;
        private decimal? _TotalValue;
        private decimal? _VATValue;
        private bool _InvoiceYesNo;
        private decimal? _TotalVAT;
        private decimal? _TotalPaid;
        private DateTime? _DatePaid;
        private DateTime? _DatePosted;
        private string _SearchInvoiceID;
        private string _JobAddress;
        private string _OrderNumber;
        private decimal _Balance;
        private bool? _IsPosted;
        private bool? _IsClosed;
        private int? _statementId;
        private string _EmailAddress;
        private string _DateInvoiceNum;

        private AccountCustomerDto _accountCustomerDto;

        public AccountInvoiceDto()
        {

        }

        public int InvoiceId
        {
            get
            {
                return _InvoiceId;
            }
            set
            {
                SetProperty(ref _InvoiceId, value);
            }
        }
        public int? InvoiceNum
        {
            get
            {
                return _InvoiceNum;
            }
            set
            {
                SetProperty(ref _InvoiceNum, value);
            }
        }
        public string CustomerAC
        {
            get
            {
                return _CustomerAC;
            }
            set
            {
                SetProperty(ref _CustomerAC, value);
            }
        }
        public string InvoiceAddress
        {
            get
            {
                return _InvoiceAddress;
            }
            set
            {
                SetProperty(ref _InvoiceAddress, value);
            }
        }
        public DateTime? InvoiceDate
        {
            get
            {
                return _InvoiceDate;
            }
            set
            {
                SetProperty(ref _InvoiceDate, value);
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
        public string SearchInvoiceID
        {
            get
            {
                return _SearchInvoiceID;
            }
            set
            {
                SetProperty(ref _SearchInvoiceID, value);
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
        public bool? IsPosted
        {
            get
            {
                return _IsPosted;
            }
            set
            {
                SetProperty(ref _IsPosted, value);
            }
        }
        public bool? IsClosed
        {
            get
            {
                return _IsClosed;
            }
            set
            {
                SetProperty(ref _IsClosed, value);
            }
        }
        public int? statementId
        {
            get
            {
                return _statementId;
            }
            set
            {
                SetProperty(ref _statementId, value);
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
        public string DateInvoiceNum
        {
            get
            {
                return _DateInvoiceNum;
            }
            set
            {
                SetProperty(ref _DateInvoiceNum, value);
            }
        }


        public AccountCustomerDto AccountCustomerDto
        {
            get
            {
                return _accountCustomerDto;
            }

            set
            {
               SetProperty(ref _accountCustomerDto, value);

            }
        }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<AccountInvoiceDetail> AccountInvoiceDetails { get; set; }
    }
}
