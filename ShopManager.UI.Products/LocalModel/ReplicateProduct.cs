using ShopManager.helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.UI.Products.LocalModel
{
    public class ReplicateProduct: ValidatableBindableBase
    {
        private string _ProductCode;

        [Required]
        public string ProductCode
        {
            get { return _ProductCode; }
            set { SetProperty(ref _ProductCode,value); }
        }
        private string _NewProductCode;

        [Required]
        public string NewProductCode
        {
            get { return _NewProductCode; }
            set { SetProperty(ref _NewProductCode, value); }
        }
        private string _ProductName;
        public string ProductName
        {
            get { return _ProductName; }
            set {SetProperty(ref _ProductName,value); }
        }

        private string _NewProductName;
        public string NewProductName
        {
            get { return _NewProductName; }
            set { SetProperty(ref _NewProductName, value); }
        }


    }
}
