using ShopManager.helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShopManager.DTO
{
    public class AccountCreditNoteDto : ValidatableBindableBase
    {
        private int _AccountCreditNoteId;
        private int? _InvoiceNum;
        private string _CustomerAC;
        private string _CreditNoteAddress;
        private DateTime _CreditNoteDate;
        private float _Discount;
        private decimal _PostPacking;
        private decimal _TotalValue;
        private decimal _VATValue;
        private bool _CreditNoteYesNo;
        private decimal _TotalVAT;
        private decimal? _TotalPaid;
        private DateTime? _DatePaid;
        private DateTime? _DatePosted;
        private string _SearchCreditNoteId;
        private string _JobAddress;
        private string _OrderNumber;
        private decimal _Balance;
        private bool _IsPosted;
        private bool _IsClosed;
        private int? _statementId;
        private string _EmailAddress;
        private string _DateCreditNoteNum;
        private List<AccountCreditNoteDetailDto> _accountCreditNoteDetailsDto;

        public AccountCreditNoteDto()
        {
            AccountCreditNoteDetailsDto = new List<AccountCreditNoteDetailDto>();
        }

        public int AccountCreditNoteId
        {
            get
            {
                return _AccountCreditNoteId;
            }
            set
            {
                SetProperty(ref _AccountCreditNoteId, value);
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
        public string CreditNoteAddress
        {
            get
            {
                return _CreditNoteAddress;
            }
            set
            {
                SetProperty(ref _CreditNoteAddress, value);
            }
        }
        public DateTime CreditNoteDate
        {
            get
            {
                return _CreditNoteDate;
            }
            set
            {
                SetProperty(ref _CreditNoteDate, value);
            }
        }
        public float Discount
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
        public decimal PostPacking
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
        public decimal TotalValue
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
        public decimal VATValue
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
        public bool CreditNoteYesNo
        {
            get
            {
                return _CreditNoteYesNo;
            }
            set
            {
                SetProperty(ref _CreditNoteYesNo, value);
            }
        }
        public decimal TotalVAT
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
        public string SearchCreditNoteId
        {
            get
            {
                return _SearchCreditNoteId;
            }
            set
            {
                SetProperty(ref _SearchCreditNoteId, value);
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
        public bool IsPosted
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
        public bool IsClosed
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
        public string DateCreditNoteNum
        {
            get
            {
                return _DateCreditNoteNum;
            }
            set
            {
                SetProperty(ref _DateCreditNoteNum, value);
            }
        }

        public List<AccountCreditNoteDetailDto> AccountCreditNoteDetailsDto
        {
            get { return _accountCreditNoteDetailsDto; }
            set
            {
                SetProperty(ref _accountCreditNoteDetailsDto, value);
            }
        }
    }
}
