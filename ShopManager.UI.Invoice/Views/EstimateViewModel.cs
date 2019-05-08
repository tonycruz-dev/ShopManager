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
   public class EstimateViewModel : BindableBase
    {
        private IOrderRepository _repo;
        private List<EstimateDto> _allEstimate;

        private readonly IMapper _mapper;
        private ObservableCollection<EstimateDto> _Estimates;
        private ObservableCollection<EstimateDetailDto> _EstimateDetails;
        private EstimateDto _Estimate;
        private string _SearchInput;
        public EstimateViewModel(IOrderRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;

            SubmitSearchCommand = new RelayCommand<string>(OnSearchInvoiceNum);
            ClearSearchCommand = new RelayCommand(OnClearSearch);
            PrintRecordCommand = new RelayCommand(PrintRecord);
        }
        public async void LoadEstimate()
        {
            _allEstimate = _mapper.Map<List<EstimateDto>>(await _repo.GetEstimateAsync());
            Estimates = new ObservableCollection<EstimateDto>(_allEstimate);
            if (Estimates.Count > 0)
            {
                Estimate = Estimates[0];
            }
        }

        public ObservableCollection<EstimateDto> Estimates
        {
            get { return _Estimates; }
            set
            {
                SetProperty(ref _Estimates, value);

            }
        }
        public ObservableCollection<EstimateDetailDto> EstimateDetails
        {
            get { return _EstimateDetails; }
            set { SetProperty(ref _EstimateDetails, value); }
        }

        public EstimateDto Estimate
        {
            get { return _Estimate; }
            set
            {
                SetProperty(ref _Estimate, value);
                if (_Estimate != null)
                {
                    EstimateDetails = new ObservableCollection<EstimateDetailDto>(_Estimate.EstimateDetails);
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
                Estimates = new ObservableCollection<EstimateDto>(_allEstimate);
                if (Estimates.Count > 0)
                {
                    Estimate = Estimates[0];
                }
                return;
            }
            else
            {
                Estimates = new ObservableCollection<EstimateDto>(
                    _allEstimate.Where(
                        a => a.SearchEstimateId.ToLower().Contains(searchInput.ToLower()) ||
                        a.CustomerAC.ToLower().Contains(searchInput.ToLower())));
                if (Estimates.Count > 0)
                {
                    Estimate = Estimates[0];
                }
            }
        }
        // commands
        public RelayCommand PrintRecordCommand { get; private set; }
        public RelayCommand ClearSearchCommand { get; private set; }
        public RelayCommand<string> SubmitSearchCommand { get; private set; }



        private void PrintRecord()
        {
            List<ReportsOrderModel> ResultEstimate = new List<ReportsOrderModel>();
            //Order.TotalValue ?? default(decimal);
            foreach (var item in EstimateDetails)
            {
                var rom = new ReportsOrderModel()
                {
                    Id = Estimate.EstimateId,
                    CustomerAC = Estimate.CustomerAC,
                    OrderAddress = Estimate.EstimateAddress,
                    InvoiceDate = Estimate.EstimateDate ?? default(DateTime),
                    TotalValue = Estimate.TotalValue ?? default(decimal),
                    VATValue = Estimate.TotalVAT ?? default(decimal),
                    TotalVAT = Estimate.TotalPaid ?? default(decimal),
                    JobAddress = Estimate.JobAddress,
                    Description = item.Description,
                    ProductID = item.ProductId,
                    UnitPrice = item.UnitPrice ?? default(decimal),
                    Quantity = item.Quantity ?? default(int),
                    Discount = item.Discount,
                    SubTotal = item.TotalPrice
                };
                ResultEstimate.Add(rom);
            }
            var _estimateReport = new EstimateReport();
            _estimateReport.SetDataSource(ResultEstimate);
            var printReport = new FormPrintPreview();
            printReport.ReportViewer.ToggleSidePanel = SAPBusinessObjects.WPF.Viewer.Constants.SidePanelKind.None;
            printReport.ReportViewer.ViewerCore.ReportSource = _estimateReport;
            printReport.Show();
        }

        private void OnClearSearch()
        {
            SearchInput = null;
        }

        private void OnSearchInvoiceNum(string InvoiceNum)
        {
            throw new NotImplementedException();
        }
    }
}
