using ShopManager.helper;

namespace ShopManager.DTO
{
    public class ProductCategoryDto : ValidatableBindableBase
    {
        private int _categoryId;
        private string _categoryName;

        public int CategoryId
        {
            get => _categoryId;
            set
            {
                SetProperty(ref _categoryId, value);
            }
        }
        public string CategoryName
        {
            get
            {
                return _categoryName;
            }
            set
            {
                SetProperty(ref _categoryName, value);
            }
        }
    }
}
