using ShopManager.helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.DTO
{
   public class OrderItemDto : ValidatableBindableBase
    {
        private int _Id;
        private int? _OrderID;
        private string _Description;
        private string _ProductID;
        private decimal? _UnitPrice;
         private int? _QTYOrder;
        private int? _Quantity;
        private DateTime? _DateOrderd;
        private float _Discount;
        private decimal _SubTotal;
        private int _Shortage;
        private decimal _TotalPrice;
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
        public int? OrderID
        {
            get
            {
                return _OrderID;
            }
            set
            {
                SetProperty(ref _OrderID, value);
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
        public DateTime? DateOrderd
        {
            get
            {
                return _DateOrderd;
            }
            set
            {
                SetProperty(ref _DateOrderd, value);
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
