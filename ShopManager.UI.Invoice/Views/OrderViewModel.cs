using AutoMapper;
using ShopManager.DTO;
using ShopManager.helper;
using ShopManager.UI.Invoice.Forms;
using ShopManager.UI.Invoice.Helpers;
using ShopManager.UI.Invoice.Reports;
using ShopManager.UI.Invoice.Repository;
using ShopManager.UI.Invoice.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ShopManager.UI.Invoice.Views
{
    public class OrderViewModel:BindableBase
    {
        private IOrderRepository  _repo;
        private List<ProductDto> _allProducts;
        private List<SelectAccountToInsert> _SelectedItemsToInsert;
        private readonly IMapper _mapper;
        private ObservableCollection<ProductDto> _products;
        private ObservableCollection<OrderItemDto> _orderItems;
        private string _SearchInput;


 

        public OrderViewModel(IOrderRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
            AddProductOrderItemCommand = new RelayCommand<ProductDto>(OnAddToOrderItems);
            RemoveOrderItemCommand = new RelayCommand<OrderItemDto>(OnRemoveOrderItems);
            SubmitSearchCommand = new RelayCommand<string>(OnSearchProductCode);
            ClearSearchCommand = new RelayCommand(OnClearSearch);
            PrintRecordCommand = new RelayCommand(PrintRecord);
            EditOrderItemCommand = new RelayCommand<OrderItemDto>(OnEditOrder);
            SendToAccountInvoiceCommand = new RelayCommand(OnSendToAccountInvoice);
            DiscountOrderItemCommand = new RelayCommand<OrderItemDto>(OnDiscountOrderItem);
            SetOrder();
        }

        

        public async void LoadProducts()
        {
            _allProducts = _mapper.Map<List<ProductDto>>(await _repo.GetProductsAsync());
            Products = new ObservableCollection<ProductDto>(_allProducts);
        }

        private void SetOrder()
        {
            Order = new OrderDto();
            Order.Id = getOrderId();
            Order.Address = "Add Address Here";
            Order.JobAddress = "Delivery Address Here";
            Order.OrderDate = DateTime.Now;
            Order.TotalPaid = 0;
            Order.TotalVAT = 0;
            Order.TotalValue = 0;
            OrderItems = new ObservableCollection<OrderItemDto>();
        }
        // Properties
        // List<SelectAccountToInsert> _SelectedItemsToInsert;

        public List<SelectAccountToInsert> SelectedItemsToInsert
        {
            get { return _SelectedItemsToInsert; }
            set { SetProperty(ref _SelectedItemsToInsert, value); }
        }

        public ObservableCollection<ProductDto> Products
        {
            get { return _products; }
            set { SetProperty(ref _products, value); }
        }
        public ObservableCollection<OrderItemDto> OrderItems
        {
            get { return _orderItems; }
            set { SetProperty(ref _orderItems, value); }
        }
        private OrderDto _Order;
        public OrderDto Order
        {
            get { return _Order; }
            set { SetProperty(ref _Order, value); }
        }

        private ChangeOrderQuantity _EditOrderQuantity;
        public ChangeOrderQuantity EditOrderQuantity
        {
            get { return _EditOrderQuantity; }
            set { SetProperty(ref _EditOrderQuantity, value); }
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
                Products = new ObservableCollection<ProductDto>(_allProducts);
                return;
            }
            else
            {
                Products = new ObservableCollection<ProductDto>(
                    _allProducts.Where(
                        p => p.ProductName.ToLower().Contains(searchInput.ToLower()) ||
                        p.ProductCode.ToLower().Contains(searchInput.ToLower())));
            }
        }
        private void FilterTopProduct(string searchInput)
        {

                Products = new ObservableCollection<ProductDto>(
                    _allProducts.Where(
                        p => p.ProductName.ToLower().Contains(searchInput.ToLower()) ||
                        p.ProductCode.ToLower().Contains(searchInput.ToLower())));

        }

       
        public RelayCommand<ProductDto> AddProductOrderItemCommand { get; private set; }
        public RelayCommand<OrderItemDto> RemoveOrderItemCommand { get; private set; }
        public RelayCommand<OrderItemDto> EditOrderItemCommand { get; private set; }
        public RelayCommand<OrderItemDto> DiscountOrderItemCommand { get; private set; }
        public RelayCommand SendToAccountInvoiceCommand { get; private set; }
        public RelayCommand PrintRecordCommand { get; private set; }
        public RelayCommand ClearSearchCommand { get; private set; }
        public RelayCommand<string> SubmitSearchCommand { get; private set; }

        public event Action<ProductDto> AddProductOrderItemRequest = delegate { };
        public event Action<OrderItemDto> RemoveOrderItemRequest = delegate { };
        public event Action Done = delegate { };

        private void OnAddToOrderItems(ProductDto product)
        {
            var item = new OrderItemDto();
            item.ProductID = product.ProductCode;
            item.Description = product.ProductName;
            item.QTYOrder = 1;
            item.Quantity = 1;
            item.Shortage = 0;
            item.UnitPrice = product.UnitPrice;
            item.Discount = 0;
            item.TotalPrice = product.UnitPrice;
            item.StockId = product.ProductID;
            OrderItems.Add(item);
            CalculateTotal();

            //throw new NotImplementedException();
        }
        private void OnRemoveOrderItems(OrderItemDto item)
        {
            var MessageToDisplay = "Remove Item " + item.ProductID;
            var DeleteItemForm = new DeleteForm(MessageToDisplay);
            if (DeleteItemForm.ShowDialog() == true)
            {
                OrderItems.Remove(item);
                CalculateTotal();
            }
                
        }
        private void OnClearSearch()
        {
            SearchInput = null;
        }
        private void OnSearchProductCode(string productCode)
        {
            var results = new ObservableCollection<ProductDto>(
                    _allProducts.Where(
                        p => p.ProductName.ToLower().Contains(SearchInput.ToLower()) ||
                        p.ProductCode.ToLower().Contains(SearchInput.ToLower())));
            if (results.Count > 0)
            {
                OnAddToOrderItems(results[0]);
                SearchInput = null;
            }
        }
        private int getOrderId()
        {
            var Year = DateTime.Now.Year;
            var month = DateTime.Now.Month;
            var day = DateTime.Now.Day;
            var seconds = DateTime.Now.Second;
            var result = Year.ToString() + month.ToString() + day.ToString() + seconds.ToString();
            return int.Parse(result);
        }
        private void PrintRecord()
        {
            List<ReportsOrderModel> ResultAccountInvoice = new List<ReportsOrderModel>();
            //Order.TotalValue ?? default(decimal);
            foreach (var item in OrderItems)
            {
                var rom = new ReportsOrderModel()
                {
                    Id = Order.Id,
                    CustomerAC = Order.AccountAC,
                    OrderAddress = Order.Address,
                    InvoiceDate = Order.OrderDate ?? default(DateTime),
                    TotalValue = Order.TotalValue ?? default(decimal),
                    VATValue = Order.TotalVAT ?? default(decimal),
                    TotalVAT = Order.TotalPaid ?? default(decimal),
                    JobAddress = Order.JobAddress,
                    Description = item.Description,
                    ProductID = item.ProductID,
                    UnitPrice = item.UnitPrice ?? default(decimal),
                    Quantity = item.Quantity ?? default(int),
                    Discount = item.Discount,
                    SubTotal = item.TotalPrice
                };
                 ResultAccountInvoice.Add(rom);
            }
            var _OrderRepot = new OrderReport();
            _OrderRepot.SetDataSource(ResultAccountInvoice);
            var printReport = new FormPrintPreview();
            printReport.ReportViewer.ToggleSidePanel = SAPBusinessObjects.WPF.Viewer.Constants.SidePanelKind.None;
            printReport.ReportViewer.ViewerCore.ReportSource = _OrderRepot;
            printReport.Show();
        }
        private void OnEditOrder(OrderItemDto item)
        {
            var product = _allProducts.Where(p => p.ProductID == item.StockId).SingleOrDefault();
            EditOrderQuantity = new ChangeOrderQuantity
            {
                ProductCode = product.ProductCode,
                QuantityOrder = item.QTYOrder ?? default(int),
                QuantityInStock = product.QtyOnOrder ?? default(int),
                ProductId = item.StockId

            };

            var FormChangwQuantity = new FormChangeOrderQty(EditOrderQuantity);
            if (FormChangwQuantity.ShowDialog() == true)
            {
                item.QTYOrder = EditOrderQuantity.QuantityOrder;
                item.Quantity = EditOrderQuantity.Allocated;
                item.Shortage = EditOrderQuantity.QuantityOrder - EditOrderQuantity.Allocated;
                item.TotalPrice = EditOrderQuantity.Allocated * item.UnitPrice ?? default(decimal);
                CalculateTotal();
            }

        }
        private void OnDiscountOrderItem(OrderItemDto item)
        {
           
            var MessageToDisplay = "Discount Item " + item.ProductID;
            var DiscountItemForm = new DiscountForm(MessageToDisplay);
            if (DiscountItemForm.ShowDialog() == true)
            {
                var disc = Convert.ToDouble(DiscountItemForm.TxtDiscount.Text);
                item.Discount = Convert.ToSingle(disc/100);
                
                CalculateTotal();
            }
        }
        //
        private void CalculateTotal()
        {
            decimal SumTotal = 0;
            foreach (var item in OrderItems)
            {
                //If discountValue <> 0 Then
                if (item.Discount > 0)
                {
                    var up = item.UnitPrice ?? default(decimal);
                    var qty = item.Quantity ?? default(int);
                    var upqty = Convert.ToDecimal(up * qty);
                    var dsc = Convert.ToSingle(1 - item.Discount);
                    var discountedPrice = (decimal)dsc * upqty;

                    item.SubTotal = discountedPrice;
                    SumTotal = SumTotal + item.SubTotal;
                }
                else
                {
                    item.SubTotal = item.Quantity * item.UnitPrice ?? default(decimal);
                    SumTotal = SumTotal + item.SubTotal;
                }
                

            }
            Order.TotalValue = SumTotal;
            var tov = Order.TotalValue ?? default(decimal);
            var vatval = (double)tov * 0.2;
            Order.TotalVAT = (decimal)vatval;
            Order.TotalPaid = tov + Order.TotalVAT;
        }
    

        private async void OnSendToAccountInvoice()
        {
            SelectedItemsToInsert = await _repo.GetAccountCustomersSelectAsync();
            var frmToInsert = new FormSelectAccountToInsert(SelectedItemsToInsert);
            if (frmToInsert.ShowDialog() == true)
            {
                var ac = await _repo.GetAccountCustomerAsync(frmToInsert.SelectItem.Account);
                var accInvoice = CustomerInvoiceHelper.AccountCustomerToInvoice(ac, Order);
                await _repo.AddAccountInvoiceAsync(accInvoice);
                foreach (var item in OrderItems)
                {
                   var invDetails = CustomerInvoiceHelper.AccountCustomerToInvoiceDetails(accInvoice.InvoiceId, item);
                   await _repo.AddAccountInvoiceDetailAsync(invDetails);
                }
                frmToInsert.Close();
                SetOrder();
                Done();

            }


        }
    }
}
