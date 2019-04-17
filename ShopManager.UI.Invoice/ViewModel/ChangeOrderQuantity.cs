using ShopManager.helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.UI.Invoice.ViewModel
{
   public class ChangeOrderQuantity: BindableBase
    {
        private int _QuantityOrder;
        public int QuantityOrder
        {
            get { return _QuantityOrder; }
            set
            {
                SetProperty(ref _QuantityOrder, value);
                CalculateQuantity();
            }
        }

        private int _QuantityInStock;
        public int QuantityInStock
        {
            get { return _QuantityInStock; }
            set
            {
                SetProperty(ref _QuantityInStock, value);
                CalculateQuantity();

            }
        }
        private int _Allocated;
        public int Allocated
        {
            get
            {
                return _Allocated;
            }
            set
            {
                SetProperty(ref _Allocated, value);
            }
        }
        private string _ProductCode;
        public string ProductCode
        {
            get { return _ProductCode; }
            set
            {
                SetProperty(ref _ProductCode, value);
            }
        }
        private int _ProductId;
        public int ProductId
        {
            get { return _ProductId; }
            set
            {
                SetProperty(ref _ProductId, value);
            }
        }
        private int CalculateQuantity()
        {
            if (QuantityOrder > QuantityInStock)
            {
                Allocated = QuantityInStock;
                return QuantityInStock;
            }
            else
            {
                Allocated = QuantityOrder;
                return QuantityOrder;
            }
        }

    }
}
