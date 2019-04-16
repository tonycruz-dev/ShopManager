using ShopManager.helper;
using System;

namespace ShopManager.DTO
{
    public class CashInvoiceDetailDto : ValidatableBindableBase
    {
        private int _CashInvoiceDetailId;
        private int? _InvoiceId;
        private string _Description;
        private string _ProductId;
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
        public int CashInvoiceDetailId
        {
            get
            {
                return _CashInvoiceDetailId;
            }
            set
            {
                SetProperty(ref _CashInvoiceDetailId, value);
            }
        }
        public int? InvoiceId
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
        public string ProductId
        {
            get
            {
                return _ProductId;
            }
            set
            {
                SetProperty(ref _ProductId, value);
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
