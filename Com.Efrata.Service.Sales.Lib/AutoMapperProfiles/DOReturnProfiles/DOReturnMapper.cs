using AutoMapper;
using Com.Efrata.Service.Sales.Lib.Models.DOReturn;
using Com.Efrata.Service.Sales.Lib.ViewModels.DOReturn;

namespace Com.Efrata.Service.Sales.Lib.AutoMapperProfiles.DOReturnProfiles
{
    public class DOReturnMapper : Profile
    {
        public DOReturnMapper()
        {
            CreateMap<DOReturnModel, DOReturnViewModel>()

                .ForPath(d => d.ReturnFrom.Id, opt => opt.MapFrom(s => s.ReturnFromId))
                .ForPath(d => d.ReturnFrom.Name, opt => opt.MapFrom(s => s.ReturnFromName))

                .ReverseMap();
        }
    }
}
