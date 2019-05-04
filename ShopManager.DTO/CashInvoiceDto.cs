using ShopManager.helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.DTO
{
    public class CashInvoiceDto : ValidatableBindableBase
    {
        private int _InvoiceID;
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
        private string _OrderNumber;
        private string _JobAddress;
        private string _EmailAddress;
        private decimal? _Deposite;
        private bool? _IsCash;
        private bool? _IsCard;
        private bool? _IsCheque;
        private string _InvoiceNumCount;
        private string _DateInvoiceNum;
        private string _PaymentDisplay;
        private bool? _IsClosed;
        private List<CashInvoiceDetailDto> _cashInvoiceDetails;

        public int InvoiceID
        {
            get
            {
                return _InvoiceID;
            }
            set
            {
                SetProperty(ref _InvoiceID, value);
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
        public decimal? Deposite
        {
            get
            {
                return _Deposite;
            }
            set
            {
                SetProperty(ref _Deposite, value);
            }
        }
        public bool? IsCash
        {
            get
            {
                return _IsCash;
            }
            set
            {
                SetProperty(ref _IsCash, value);
            }
        }
        public bool? IsCard
        {
            get
            {
                return _IsCard;
            }
            set
            {
                SetProperty(ref _IsCard, value);
            }
        }
        public bool? IsCheque
        {
            get
            {
                return _IsCheque;
            }
            set
            {
                SetProperty(ref _IsCheque, value);
            }
        }
        public string InvoiceNumCount
        {
            get
            {
                return _InvoiceNumCount;
            }
            set
            {
                SetProperty(ref _InvoiceNumCount, value);
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
        public string PaymentDisplay
        {
            get
            {
                return _PaymentDisplay;
            }
            set
            {
                SetProperty(ref _PaymentDisplay, value);
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
        public List<CashInvoiceDetailDto> CashInvoiceDetails
        {
            get
            {
                return _cashInvoiceDetails;
            }
            set
            {
                SetProperty(ref _cashInvoiceDetails, value);
            }
        }
    }
}
