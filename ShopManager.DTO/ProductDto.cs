using ShopManager.helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.DTO
{
    public class ProductDto : ValidatableBindableBase
    {
        private int _ProductID;
        private string _ProductName;
        private string _ProductCode;
        private int _CategoryID;
        private decimal _UnitPrice;
        private decimal _UnitCost;
        private int? _QtyInStock;
        private int? _QtySold;
        private int? _QtyOnOrder;
        private int? _Sortage;
        private bool _Discontinued;
        private string _Specifications;
        private string _ContentDetails;
        private DateTime? _DateUpdated;
        private DateTime? _ModifiedDate;
        private float? _Discount;
        private string _GroupName;
        private float? _SupplierDiscount;
        [Required]
        public int ProductID
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
        [Required]
        public string ProductName
        {
            get
            {
                return _ProductName;
            }
            set
            {
                SetProperty(ref _ProductName, value);
            }
        }
        [Required]
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
        public int CategoryID
        {
            get
            {
                return _CategoryID;
            }
            set
            {
                SetProperty(ref _CategoryID, value);
            }
        }
        [Required]
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
        [Required]
        public decimal UnitCost
        {
            get
            {
                
                return _UnitCost;
            }
            set
            {
                SetProperty(ref _UnitCost, value);
            }
        }
        [Required]
        public int? QtyInStock
        {
            get
            {
                return _QtyInStock;
            }
            set
            {
                SetProperty(ref _QtyInStock, value);
            }
        }
        public int? QtySold
        {
            get
            {
                return _QtySold;
            }
            set
            {
                SetProperty(ref _QtySold, value);
            }
        }
        public int? QtyOnOrder
        {
            get
            {
                return _QtyOnOrder;
            }
            set
            {
                SetProperty(ref _QtyOnOrder, value);
            }
        }
        public int? Sortage
        {
            get
            {
                return _Sortage;
            }
            set
            {
                SetProperty(ref _Sortage, value);
            }
        }
        public bool Discontinued
        {
            get
            {
                return _Discontinued;
            }
            set
            {
                SetProperty(ref _Discontinued, value);
            }
        }
        public string Specifications
        {
            get
            {
                return _Specifications;
            }
            set
            {
                SetProperty(ref _Specifications, value);
            }
        }
        public string ContentDetails
        {
            get
            {
                return _ContentDetails;
            }
            set
            {
                SetProperty(ref _ContentDetails, value);
            }
        }
        public DateTime? DateUpdated
        {
            get
            {
                return _DateUpdated;
            }
            set
            {
                SetProperty(ref _DateUpdated, value);
            }
        }
        public DateTime? ModifiedDate
        {
            get
            {
                return _ModifiedDate;
            }
            set
            {
                SetProperty(ref _ModifiedDate, value);
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
        public string GroupName
        {
            get
            {
                return _GroupName;
            }
            set
            {
                SetProperty(ref _GroupName, value);
            }
        }
        public float? SupplierDiscount
        {
            get
            {
                return _SupplierDiscount;
            }
            set
            {
                SetProperty(ref _SupplierDiscount, value);
            }
        }

    }
}
