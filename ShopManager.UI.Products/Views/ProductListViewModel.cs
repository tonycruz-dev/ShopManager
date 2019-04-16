using AutoMapper;
using ShopManager.DTO;
using ShopManager.helper;
using ShopManager.UI.Products.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.UI.Products.Views
{
   public class ProductListViewModel: BindableBase
    {
        private readonly IProductsRepository _repo;
        private readonly IMapper _mapper;
        private List<ProductDto> _allProducts;
        private ObservableCollection<ProductDto> _products;
        private string _searchInput;

        public ProductListViewModel(IProductsRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
            AddProductCommand = new RelayCommand(OnAddProduct);
            EditProductCommand = new RelayCommand<ProductDto>(OnEditProduct);
            ClearSearchCommand = new RelayCommand(OnClearSearch);
        }
        public async void LoadProducts()
        {
            _allProducts = _mapper.Map<List<ProductDto>>(await _repo.GetProductsAsync());
            Products = new ObservableCollection<ProductDto>(_allProducts);

        }
 
        // Properties
         public ObservableCollection<ProductDto>  Products
        {
            get { return _products; }
            set { SetProperty(ref _products , value); }
        }
        public string SearchInput
        {
            get { return _searchInput; }
            set
            {
                SetProperty(ref _searchInput, value);
                FilterProduct(_searchInput);
            }
        }


        // Commands
        public RelayCommand AddProductCommand { get; private set; }
        public RelayCommand<ProductDto> EditProductCommand { get; private set; }
        public RelayCommand ClearSearchCommand { get; private set; }

        // Actions
        public event Action<ProductDto> AddProductRequest = delegate { };
        public event Action<ProductDto> EditProductRequest = delegate { };


        // functions and sub
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
        private void OnAddProduct()
        {
            AddProductRequest(new ProductDto());
        }
        private void OnEditProduct(ProductDto product)
        {
            EditProductRequest(product);
        }
        private void OnClearSearch()
        {
            SearchInput =  null;
        }

    }
}
