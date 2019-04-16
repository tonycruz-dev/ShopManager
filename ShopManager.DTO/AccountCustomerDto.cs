using ShopManager.helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.DTO
{
    public class AccountCustomerDto : ValidatableBindableBase
    {
        private string _customerAc;
        private string _companyName;
        private string _contactName;
        private string _address1;
        private string _address2;
        private string _address3;
        private string _address4;
        private string _address5;
        private string _postCode;
        private string _phone;
        private string _fax;
        private string _email;
        private string _webPage;
        private string _notePad;
        private List<AccountCreditNoteDto> _accountCreditNotesDto;

        public AccountCustomerDto()
        {
            AccountCreditNotesDto = new List<AccountCreditNoteDto>();
            // AccountInvoices = new HashSet<AccountInvoice>();
        }


        [StringLength(50)]
        public string CustomerAc
        {
            get { return _customerAc; }
            set
            {
               SetProperty(ref _customerAc , value);
            }
        }

        [Required]
        [StringLength(50)]
        public string CompanyName
        {
            get { return _companyName; }
            set
            {
               SetProperty(ref _companyName, value);
            }
        }

        [StringLength(50)]
        public string ContactName
        {
            get { return _contactName; }
            set
            {
                SetProperty(ref _contactName, value);
            }
        }

        [StringLength(50)]
        public string Address1
        {
            get { return _address1; }
            set
            {
                SetProperty(ref _address1, value);
            }
        }

        [StringLength(50)]
        public string Address2
        {
            get
            {
                return _address2;
            }

            set
            {
                SetProperty(ref _address2, value);
            }
        }

        [StringLength(50)]
        public string address3
        {
            get { return _address3; }
            set
            {
                SetProperty(ref _address3, value);
            }
        }

        [StringLength(50)]
        public string Address4
        {
            get { return _address4; }
            set
            {
                SetProperty(ref _address4, value);
            }
        }

        [StringLength(50)]
        public string address5
        {
            get { return _address5; }
            set
            {
                SetProperty(ref _address5, value);
            }
        }

        [StringLength(50)]
        public string PostCode
        {
            get { return _postCode; }
            set
            {
                SetProperty(ref _postCode, value);
            }
        }

        [StringLength(50)]
        public string Phone
        {
            get { return _phone; }
            set
            {
                SetProperty(ref _phone, value);
            }
        }

        [StringLength(50)]
        public string Fax
        {
            get { return _fax; }
            set
            {
                SetProperty(ref _fax, value);
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                SetProperty(ref _email, value);
            }
        }

        [StringLength(50)]
        public string WebPage
        {
            get { return _webPage; }
            set
            {
                SetProperty(ref _webPage, value);
            }
        }

        public string NotePad
        {
            get { return _notePad; }
            set
            {
                SetProperty(ref _notePad, value);
            }
        }


        public List<AccountCreditNoteDto> AccountCreditNotesDto
        {
            get { return _accountCreditNotesDto; }
            set
            {
                SetProperty(ref _accountCreditNotesDto, value);
            }
        }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<AccountInvoice> AccountInvoices { get; set; }
    }
}
