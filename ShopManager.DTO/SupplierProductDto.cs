using ShopManager.helper;
using System;

namespace ShopManager.DTO
{
    public class SupplierProductDto : ValidatableBindableBase
    {
        private int _SupplierProductId;
        private int _SupplierId;
        private int _ProductId;
        private decimal? _CostPrice;
        private DateTime? _DateUpdate;
        public int SupplierProductId
        {
            get
            {
                return _SupplierProductId;
            }
            set
            {
                SetProperty(ref _SupplierProductId, value);
            }
        }
        public int SupplierId
        {
            get
            {
                return _SupplierId;
            }
            set
            {
                SetProperty(ref _SupplierId, value);
            }
        }
        public int ProductId
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
        public decimal? CostPrice
        {
            get
            {
                return _CostPrice;
            }
            set
            {
                SetProperty(ref _CostPrice, value);
            }
        }
        public DateTime? DateUpdate
        {
            get
            {
                return _DateUpdate;
            }
            set
            {
                SetProperty(ref _DateUpdate, value);
            }
        }
    }
}
