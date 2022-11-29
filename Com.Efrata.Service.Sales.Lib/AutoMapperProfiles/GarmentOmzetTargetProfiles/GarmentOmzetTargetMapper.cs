using AutoMapper;
using Com.Efrata.Service.Sales.Lib.Models.GarmentOmzetTargetModel;
using Com.Efrata.Service.Sales.Lib.ViewModels.GarmentOmzetTargetViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Efrata.Service.Sales.Lib.AutoMapperProfiles.GarmentOmzetTargetProfiles
{
    public class GarmentOmzetTargetMapper : Profile
    {
        public GarmentOmzetTargetMapper()
        {
            CreateMap<GarmentOmzetTarget, GarmentOmzetTargetViewModel>()
            .ForPath(d => d.SectionId, opt => opt.MapFrom(s => s.SectionId))
            .ForPath(d => d.SectionCode, opt => opt.MapFrom(s => s.SectionCode))
            .ForPath(d => d.SectionName, opt => opt.MapFrom(s => s.SectionName))
            .ReverseMap();
        }
    }
}