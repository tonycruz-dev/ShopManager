using AutoMapper;
using ShopManager.DTO;
using ShopManager.Models;

namespace ShopManager.UI.Invoice
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AccountCustomerDto, AccountCustomer>().ReverseMap();
            CreateMap<CashCustomerDto, CashCustomer>().ReverseMap();
            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<AccountInvoiceDto, AccountInvoice>().ReverseMap();
        }
    }
}