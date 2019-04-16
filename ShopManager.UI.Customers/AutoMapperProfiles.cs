using AutoMapper;
using ShopManager.DTO;
using ShopManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.UI.Customers
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
