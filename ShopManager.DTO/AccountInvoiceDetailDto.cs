using ShopManager.helper;
using System;

namespace ShopManager.DTO
{
    public class AccountInvoiceDetailDto : ValidatableBindableBase
    {
        private int _AccountInvoiceDetailId;
        private int? _InvoiceID;
        private string _Description;
        private string _ProductID;
        private decimal? _UnitPrice;
        private decimal? _SalesPrice;
        private int? _QTYOrder;
        private int? _Quantity;
        private DateTime? _DateSold;
        private float _Discount;
        private decimal _SubTotal;
        private int _Shortage;
        private bool? _IsReturn;
        private bool? _IsShortagePosted;
        private decimal _TotalPrice;
        public int AccountInvoiceDetailId
        {
            get
            {
                return _AccountInvoiceDetailId;
            }
            set
            {
                SetProperty(ref _AccountInvoiceDetailId, value);
            }
        }
        public int? InvoiceID
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
        public decimal? UnitPrice
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
        public decimal? SalesPrice
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
        public int? QTYOrder
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
        public int? Quantity
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
        public DateTime? DateSold
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
    }
}
