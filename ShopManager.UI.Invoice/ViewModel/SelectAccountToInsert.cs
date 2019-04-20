using ShopManager.helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.UI.Invoice.ViewModel
{
   public class SelectAccountToInsert: BindableBase
    {
        private string _Account;

        public string Account
        {
            get { return _Account; }
            set { SetProperty(ref _Account,value); }
        }

        private string _Company;

        public string Company
        {
            get { return _Company; }
            set {SetProperty(ref _Company,value); }
        }

    }
}
