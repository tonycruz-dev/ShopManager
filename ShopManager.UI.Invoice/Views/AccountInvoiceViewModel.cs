using AutoMapper;
using ShopManager.DTO;
using ShopManager.helper;
using ShopManager.UI.Invoice.Reports;
using ShopManager.UI.Invoice.Repository;
using ShopManager.UI.Invoice.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.UI.Invoice.Views
{
   public class AccountInvoiceViewModel: BindableBase
    {
        private IOrderRepository _repo;
        private List<AccountInvoiceDto> _allAccoutInvoices;

        private readonly IMapper _mapper;
        private ObservableCollection<AccountInvoiceDto> _AccountInvoices;
        private ObservableCollection<AccountInvoiceDetailDto> _AccountInvoiceDetails;
        private AccountInvoiceDto _AcountInvoice;
        private string _SearchInput;
        public AccountInvoiceViewModel(IOrderRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
         
            SubmitSearchCommand = new RelayCommand<string>(OnSearchInvoiceNum);
            ClearSearchCommand = new RelayCommand(OnClearSearch);
            PrintRecordCommand = new RelayCommand(PrintRecord);
           
        }
        public async void LoadAccountInvoice()
        {
            _allAccoutInvoices = _mapper.Map<List<AccountInvoiceDto>>(await _repo.GetAccountInvoicesAsync());
            AccountInvoices = new ObservableCollection<AccountInvoiceDto>(_allAccoutInvoices);
            if (AccountInvoices.Count > 0)
            {
                AcountInvoice = AccountInvoices[0];
            }
        }

        public ObservableCollection<AccountInvoiceDto> AccountInvoices
        {
            get { return _AccountInvoices; }
            set
            {
                SetProperty(ref _AccountInvoices, value);
                
            }
        }
        public ObservableCollection<AccountInvoiceDetailDto> AccountInvoiceDetails
        {
            get { return _AccountInvoiceDetails; }
            set { SetProperty(ref _AccountInvoiceDetails, value); }
        }

        public AccountInvoiceDto AcountInvoice
        {
            get { return _AcountInvoice; }
            set
            {
                SetProperty(ref _AcountInvoice, value);
                if (_AcountInvoice != null)
                {
                   AccountInvoiceDetails = new ObservableCollection<AccountInvoiceDetailDto>(_AcountInvoice.AccountInvoiceDetails);
                }
                
            }
        }
        public string SearchInput
        {
            get { return _SearchInput; }
            set
            {
                SetProperty(ref _SearchInput, value);
                FilterProduct(_SearchInput);
            }
        }
        private void FilterProduct(string searchInput)
        {
            if (string.IsNullOrWhiteSpace(searchInput))
            {
                AccountInvoices = new ObservableCollection<AccountInvoiceDto>(_allAccoutInvoices);
                if (AccountInvoices.Count > 0)
                {
                    AcountInvoice = AccountInvoices[0];
                }
                return;
            }
            else
            {
                AccountInvoices = new ObservableCollection<AccountInvoiceDto>(
                    _allAccoutInvoices.Where(
                        a => a.SearchInvoiceID.ToLower().Contains(searchInput.ToLower()) ||
                        a.CustomerAC.ToLower().Contains(searchInput.ToLower())));
                if (AccountInvoices.Count > 0)
                {
                    AcountInvoice = AccountInvoices[0];
                }
            }
        }
        // commands
        public RelayCommand PrintRecordCommand { get; private set; }
        public RelayCommand ClearSearchCommand { get; private set; }
        public RelayCommand<string> SubmitSearchCommand { get; private set; }



        private void PrintRecord()
        {
            List<ReportsOrderModel> ResultAccountInvoice = new List<ReportsOrderModel>();
            //Order.TotalValue ?? default(decimal);
            foreach (var item in AccountInvoiceDetails)
            {
                var rom = new ReportsOrderModel()
                {
                    Id = AcountInvoice.InvoiceId,
                    CustomerAC = AcountInvoice.CustomerAC,
                    OrderAddress = AcountInvoice.InvoiceAddress,
                    InvoiceDate = AcountInvoice.InvoiceDate ?? default(DateTime),
                    TotalValue = AcountInvoice.TotalValue ?? default(decimal),
                    VATValue = AcountInvoice.TotalVAT ?? default(decimal),
                    TotalVAT = AcountInvoice.TotalPaid ?? default(decimal),
                    JobAddress = AcountInvoice.JobAddress,
                    Description = item.Description,
                    ProductID = item.ProductID,
                    UnitPrice = item.UnitPrice ?? default(decimal),
                    Quantity = item.Quantity ?? default(int),
                    Discount = item.Discount,
                    SubTotal = item.TotalPrice
                };
                ResultAccountInvoice.Add(rom);
            }
            var _accountInvoiceRepot = new AccountInvoiceReport();
            _accountInvoiceRepot.SetDataSource(ResultAccountInvoice);
            var printReport = new FormPrintPreview();
            printReport.ReportViewer.ToggleSidePanel = SAPBusinessObjects.WPF.Viewer.Constants.SidePanelKind.None;
            printReport.ReportViewer.ViewerCore.ReportSource = _accountInvoiceRepot;
            printReport.Show();
        }

        private void OnClearSearch()
        {
            throw new NotImplementedException();
        }

        private void OnSearchInvoiceNum(string InvoiceNum)
        {
            throw new NotImplementedException();
        }
    }
}
