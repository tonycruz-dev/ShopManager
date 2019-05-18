using ShopManager.helper;
using System;

namespace ShopManager.DTO
{
    public class ProductHistoryDto : ValidatableBindableBase
    {
        private int _id;
        private int _productId;
        private string _productName;
        private string _productCode;
        private decimal _unitPrice;
        private decimal _unitCost;
        private string _specifications;
        private DateTime _dateAction;
        private string _barCode;

        public int Id
        {
            get { return _id; }
            set
            {
                SetProperty(ref _id, value);
            }
        }

        public int ProductId
        {
            get => _productId; set
            {
                SetProperty(ref _productId, value);
            }
        }

        public string ProductName
        {
            get => _productName; set
            {
                SetProperty(ref _productName, value);
            }
        }

        public string ProductCode
        {
            get
            {
                return _productCode;
            }

            set
            {
                SetProperty(ref _productCode, value);
            }
        }

        public decimal UnitPrice
        {
            get
            {
                return _unitPrice;
            }

            set
            {
                SetProperty(ref _unitPrice, value);
            }
        }

        public decimal UnitCost
        {
            get
            {
                return _unitCost;
            }
            set
            {
                SetProperty(ref _unitCost, value);
            }
        }

        public string Specifications
        {
            get { return _specifications; }
            set
            {
                SetProperty(ref _specifications, value);
            }
        }
        public DateTime DateAction
        {
            get { return _dateAction; }
            set
            {
                SetProperty(ref _dateAction, value);
            }
        }

        public string BarCode
        {
            get { return _barCode; }
            set
            {
               SetProperty(ref _barCode, value);
            }
        }
    }
}
