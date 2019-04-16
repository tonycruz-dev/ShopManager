using ShopManager.helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.DTO
{
    public class SupplierOrderDto : ValidatableBindableBase
    {
        private int _SupplierOrderId;
        private string _SupplierId;
        private string _CompanyName;
        private decimal? _TotalPaid;
        private DateTime? _DateOrder;
        private string _SearchOrderID;
        private int? _MainSupplierID;
        private string _OrderNumber;
        private string _NoteDetails;
        private decimal? _VATValue;
        private decimal? _TotalVAT;
        private string _EmailAddress;
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
        public string SupplierId
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
        public string CompanyName
        {
            get
            {
                return _CompanyName;
            }
            set
            {
                SetProperty(ref _CompanyName, value);
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
        public DateTime? DateOrder
        {
            get
            {
                return _DateOrder;
            }
            set
            {
                SetProperty(ref _DateOrder, value);
            }
        }
        public string SearchOrderID
        {
            get
            {
                return _SearchOrderID;
            }
            set
            {
                SetProperty(ref _SearchOrderID, value);
            }
        }
        public int? MainSupplierID
        {
            get
            {
                return _MainSupplierID;
            }
            set
            {
                SetProperty(ref _MainSupplierID, value);
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
        public string NoteDetails
        {
            get
            {
                return _NoteDetails;
            }
            set
            {
                SetProperty(ref _NoteDetails, value);
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
    }
}
