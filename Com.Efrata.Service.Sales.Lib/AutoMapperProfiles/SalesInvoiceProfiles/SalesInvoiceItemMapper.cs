using AutoMapper;
using Com.Efrata.Service.Sales.Lib.Models.SalesInvoice;
using Com.Efrata.Service.Sales.Lib.ViewModels.SalesInvoice;

namespace Com.Efrata.Service.Sales.Lib.AutoMapperProfiles.SalesInvoiceProfiles
{
    public class SalesInvoiceItemMapper : Profile
    {
        public SalesInvoiceItemMapper()
        {
            CreateMap<SalesInvoiceItemModel, SalesInvoiceItemViewModel>()

                .ReverseMap();
        }
    }
}
