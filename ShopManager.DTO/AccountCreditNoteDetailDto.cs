using ShopManager.helper;
using System;
using System.ComponentModel.DataAnnotations;

namespace ShopManager.DTO
{
    public class AccountCreditNoteDetailDto : ValidatableBindableBase
    {
        private int _AccountCreditNoteDetailId;
        private int _CreditNoteDetailId;
        private string _Description;
        private string _ProductID;
        private decimal _UnitPrice;
        private decimal _SalesPrice;
        private int _QTYOrder;
        private int _Quantity;
        private DateTime _DateSold;
        private float _Discount;
        private decimal _SubTotal;
        private int _Shortage;
        private bool? _IsReturn;
        private bool? _IsShortagePosted;
        private decimal _TotalPrice;
        private AccountCreditNoteDto _accountCreditNoteDto;

        public int AccountCreditNoteDetailId
        {
            get
            {
                return _AccountCreditNoteDetailId;
            }
            set
            {
                SetProperty(ref _AccountCreditNoteDetailId, value);
            }
        }
        public int CreditNoteDetailId
        {
            get
            {
                return _CreditNoteDetailId;
            }
            set
            {
                SetProperty(ref _CreditNoteDetailId, value);
            }
        }
        public string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                SetProperty(ref _Description, value);
            }
        }
        public string ProductID
        {
            get
            {
                return _ProductID;
            }
            set
            {
                SetProperty(ref _ProductID, value);
            }
        }
        public decimal UnitPrice
        {
            get
            {
                return _UnitPrice;
            }
            set
            {
                SetProperty(ref _UnitPrice, value);
            }
        }
        public decimal SalesPrice
        {
            get
            {
                return _SalesPrice;
            }
            set
            {
                SetProperty(ref _SalesPrice, value);
            }
        }
        public int QTYOrder
        {
            get
            {
                return _QTYOrder;
            }
            set
            {
                SetProperty(ref _QTYOrder, value);
            }
        }
        public int Quantity
        {
            get
            {
                return _Quantity;
            }
            set
            {
                SetProperty(ref _Quantity, value);
            }
        }
        public DateTime DateSold
        {
            get
            {
                return _DateSold;
            }
            set
            {
                SetProperty(ref _DateSold, value);
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
        public decimal SubTotal
        {
            get
            {
                return _SubTotal;
            }
            set
            {
                SetProperty(ref _SubTotal, value);
            }
        }
        public int Shortage
        {
            get
            {
                return _Shortage;
            }
            set
            {
                SetProperty(ref _Shortage, value);
            }
        }
        public bool? IsReturn
        {
            get
            {
                return _IsReturn;
            }
            set
            {
                SetProperty(ref _IsReturn, value);
            }
        }
        public bool? IsShortagePosted
        {
            get
            {
                return _IsShortagePosted;
            }
            set
            {
                SetProperty(ref _IsShortagePosted, value);
            }
        }
        public decimal TotalPrice
        {
            get
            {
                return _TotalPrice;
            }
            set
            {
                SetProperty(ref _TotalPrice, value);
            }
        }

        public AccountCreditNoteDto AccountCreditNoteDto
        {
            get
            {
                return _accountCreditNoteDto;
            }

            set
            {
                SetProperty(ref _accountCreditNoteDto, value);
            }
        }
    }
}
