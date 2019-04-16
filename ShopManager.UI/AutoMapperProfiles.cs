using AutoMapper;
using ShopManager.DTO;
using ShopManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.UI
{
   public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AccountCustomerDto, AccountCustomer>().ReverseMap();
            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<AccountInvoiceDto, AccountInvoice>().ReverseMap();
        }
    }
}
