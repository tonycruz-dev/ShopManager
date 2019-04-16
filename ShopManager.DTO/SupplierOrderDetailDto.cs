using ShopManager.helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.DTO
{
    public class SupplierOrderDetailDto : ValidatableBindableBase
    {
        private int _SupplierOrderDetailId;
        private int _SupplierOrderId;
        private string _Descriptions;
        private string _ProductId;
        private string _ProductCode;
        private decimal? _UnitPrice;
        private int? _Quantity;
        private decimal _TotalLine;
        private decimal? _TotalPrice;
        private float? _Discount;
        private decimal? _SalesPrice;
        public int SupplierOrderDetailId
        {
            get
            {
                return _SupplierOrderDetailId;
            }
            set
            {
                SetProperty(ref _SupplierOrderDetailId, value);
            }
        }
        public int SupplierOrderId
        {
            get
            {
                return _SupplierOrderId;
            }
            set
            {
                SetProperty(ref _SupplierOrderId, value);
            }
        }
        public string Descriptions
        {
            get
            {
                return _Descriptions;
            }
            set
            {
                SetProperty(ref _Descriptions, value);
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
        public string ProductCode
        {
            get
            {
                return _ProductCode;
            }
            set
            {
                SetProperty(ref _ProductCode, value);
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
        public decimal TotalLine
        {
            get
            {
                return _TotalLine;
            }
            set
            {
                SetProperty(ref _TotalLine, value);
            }
        }
        public decimal? TotalPrice
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
    }
}
