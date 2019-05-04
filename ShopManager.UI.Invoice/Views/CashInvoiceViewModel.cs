﻿using AutoMapper;
using ShopManager.DTO;
using ShopManager.helper;
using ShopManager.UI.Invoice.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.UI.Invoice.Views
{
    public class CashInvoiceViewModel: BindableBase
    {
        private IOrderRepository _repo;
        private List<CashInvoiceDto> _allCashInvoices;

        private readonly IMapper _mapper;
        private ObservableCollection<CashInvoiceDto> _CashInvoices;
        private ObservableCollection<CashInvoiceDetailDto> _CashInvoiceDetails;
        private CashInvoiceDto _CashInvoice;
        private string _SearchInput;
        public CashInvoiceViewModel(IOrderRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;

            SubmitSearchCommand = new RelayCommand<string>(OnSearchInvoiceNum);
            ClearSearchCommand = new RelayCommand(OnClearSearch);
            PrintRecordCommand = new RelayCommand(PrintRecord);
        }
        public async void LoadCashInvoice()
        {
            _allCashInvoices = _mapper.Map<List<CashInvoiceDto>>(await _repo.GetCashInvoiceAsync());
            CashInvoices = new ObservableCollection<CashInvoiceDto>(_allCashInvoices);
            if (CashInvoices.Count > 0)
            {
                CashInvoice = CashInvoices[0];
            }
        }

        public ObservableCollection<CashInvoiceDto> CashInvoices
        {
            get { return _CashInvoices; }
            set
            {
                SetProperty(ref _CashInvoices, value);

            }
        }
        public ObservableCollection<CashInvoiceDetailDto> CashInvoiceDetails
        {
            get { return _CashInvoiceDetails; }
            set { SetProperty(ref _CashInvoiceDetails, value); }
        }

        public CashInvoiceDto CashInvoice
        {
            get { return _CashInvoice; }
            set
            {
                SetProperty(ref _CashInvoice, value);
                if (_CashInvoice != null)
                {
                    CashInvoiceDetails = new ObservableCollection<CashInvoiceDetailDto>(_CashInvoice.CashInvoiceDetails);
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
                CashInvoices = new ObservableCollection<CashInvoiceDto>(_allCashInvoices);
                if (CashInvoices.Count > 0)
                {
                    CashInvoice = CashInvoices[0];
                }
                return;
            }
            else
            {
                CashInvoices = new ObservableCollection<CashInvoiceDto>(
                    _allCashInvoices.Where(
                        a => a.SearchInvoiceID.ToLower().Contains(searchInput.ToLower()) ||
                        a.CustomerAC.ToLower().Contains(searchInput.ToLower())));
                if (CashInvoices.Count > 0)
                {
                    CashInvoice = CashInvoices[0];
                }
            }
        }
        // commands
        public RelayCommand PrintRecordCommand { get; private set; }
        public RelayCommand ClearSearchCommand { get; private set; }
        public RelayCommand<string> SubmitSearchCommand { get; private set; }



        private void PrintRecord()
        {
            throw new NotImplementedException();
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
